using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ShoppingApp.Models;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;


namespace ShoppingApp.Controllers
{
    public class ShoppingCartController : Controller
    {
        public static List<ShoppingCart> SC = new List<ShoppingCart>();
        public static List<ShoppingCart> result = new List<ShoppingCart>();
        public IActionResult Index()
        {
            long PhoneNumber = Convert.ToInt64(HttpContext.Session.GetString("UserNum"));
            if (PhoneNumber != 0)
            {
                if (SC.Any(model => model.PhoneNumber == PhoneNumber))
                {
                    foreach (var item in SC)
                    {
                        result = SC.Where(e => e.PhoneNumber == PhoneNumber).ToList();
                    }
                    return View(result);
                }
                else
                {
                    return RedirectToAction("NoItemsinCart");
                }
            }
            else
            {
                return RedirectToAction("Login", "UserRegister");
            }
        }
        public IActionResult NoItemsinCart()
        {
            return View();
        }
        public IActionResult AddItem(int ItemId, string ProductName, int ProductPrice)
        {
            long PhoneNumber = Convert.ToInt64(HttpContext.Session.GetString("UserNum"));
            if (PhoneNumber != 0)
            {
                if (SC.Any(model => model.ItemId == ItemId && model.PhoneNumber == PhoneNumber))
                {
                    var n = from r in SC where r.ItemId == ItemId select r;
                    n.First().Quantity = n.First().Quantity + 1;
                    n.First().TotalPrice = n.First().TotalPrice * n.First().Quantity;
                }
                else
                {
                    int TotalPrice = ProductPrice * 1;
                    SC.Add(new ShoppingCart(ItemId, ProductName, ProductPrice, 1, TotalPrice, PhoneNumber));
                }
                foreach (var item in SC)
                {
                    result = SC.Where(e => e.PhoneNumber == PhoneNumber).ToList();
                }
                return View(result);
            }
            else
            {
                return RedirectToAction("Login", "UserRegister");
            }
        }

        public IActionResult DeleteItem(int id)
        {
            string Uname = HttpContext.Session.GetString("UserFirstName");
            if (Uname != null)
            {
                var valuesToRemove = SC.Where(i => i.ItemId == id).ToList();

                foreach (var item in valuesToRemove)
                {
                    SC.Remove(item);
                    result.Remove(item);
                }
                return View();
            }
            else
            {
                return RedirectToAction("Login", "UserRegister");
            }
        }

        public IActionResult PaymentPage(int id, int Qty)
        {
            string Uname = HttpContext.Session.GetString("UserFirstName");
            if (Uname != null)
            {
                HttpContext.Session.SetInt32("GrandTotal", id);
                HttpContext.Session.SetInt32("TotalQuantity", Qty);
                ViewBag.TotalCost = id;
                return View();
            }
            else
            {
                return RedirectToAction("Login", "UserRegister");
            }
        }
        public async Task<ActionResult> PaymentConfirmed()
        {
            string Uname = HttpContext.Session.GetString("UserFirstName");
            if (Uname != null)
            {
                int TotalAmt = Convert.ToInt32(HttpContext.Session.GetInt32("GrandTotal"));
                int Qty = Convert.ToInt32(HttpContext.Session.GetInt32("TotalQuantity"));
                OrderDetail od = new OrderDetail();
                od.OrderDate = DateTime.Today;
                od.OrderDeliveryDate = DateTime.Today.AddDays(2);
                long PhoneNumber = Convert.ToInt64(HttpContext.Session.GetString("UserNum"));
                od.CustomerMobNo = PhoneNumber;
                od.QuantityOrdered = Qty;
                od.OrderTotalAmount = TotalAmt;
                OrderDetail odObj = new OrderDetail();
                using (var httpClient = new HttpClient())
                {
                    StringContent content = new StringContent(JsonConvert.SerializeObject(od), Encoding.UTF8, "application/json");

                    using (var response = await httpClient.PostAsync("https://localhost:44309/api/OrderDetails", content))
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                    }
                }
                List<OrderDetail> GetOrderDetails = new List<OrderDetail>();
                dynamic LastOrder = 0;
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:44309/");

                    client.DefaultRequestHeaders.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    HttpResponseMessage Res = await client.GetAsync("api/OrderDetails/Customer/" + PhoneNumber);

                    if (Res.IsSuccessStatusCode)
                    {
                        var OD = Res.Content.ReadAsStringAsync().Result;

                        GetOrderDetails = JsonConvert.DeserializeObject<List<OrderDetail>>(OD);

                    }
                    LastOrder = GetOrderDetails.Last();

                    
                }
                return View(LastOrder);
            }
            else
            {
                return RedirectToAction("Login", "UserRegister");
            }
        }
        public IActionResult ProductsOrdered()
        {
            long PhoneNumber = Convert.ToInt64(HttpContext.Session.GetString("UserNum"));
            var valuesToRemove = SC.Where(i => i.PhoneNumber == PhoneNumber).ToList();
            foreach (var item in valuesToRemove)
            {
                SC.Remove(item);
                result.Remove(item);
            }
            return View(valuesToRemove);
        }

        public IActionResult CancelPayment()
        {
            string Uname = HttpContext.Session.GetString("UserFirstName");
            if (Uname != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login", "UserRegister");
            }
        }
        public async Task<ActionResult> OrderDetails()
        {
            string Uname = HttpContext.Session.GetString("UserFirstName");
            if (Uname != null)
            {
                List<OrderDetail> GetOrderDetails = new List<OrderDetail>();
                long PhoneNumber = Convert.ToInt64(HttpContext.Session.GetString("UserNum"));
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:44309/");

                    client.DefaultRequestHeaders.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    HttpResponseMessage Res = await client.GetAsync("api/OrderDetails/Customer/" + PhoneNumber);

                    if (Res.IsSuccessStatusCode)
                    {
                        var OD = Res.Content.ReadAsStringAsync().Result;
                        GetOrderDetails = JsonConvert.DeserializeObject<List<OrderDetail>>(OD);
                    }
                    var LastOrder = GetOrderDetails.Last();
                    return View(LastOrder);
                }
            }
            else
            {
                return RedirectToAction("Login", "UserRegister");
            }
        }

        public async Task<ActionResult> OrderHistory()
        {
            string Uname = HttpContext.Session.GetString("UserFirstName");
            if (Uname != null)
            {
                List<OrderDetail> GetOrderDetails = new List<OrderDetail>();
                long PhoneNumber = Convert.ToInt64(HttpContext.Session.GetString("UserNum"));
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:44309/");

                    client.DefaultRequestHeaders.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    HttpResponseMessage Res = await client.GetAsync("api/OrderDetails/Customer/" + PhoneNumber);

                    if (Res.IsSuccessStatusCode)
                    {
                        var EmpResponse = Res.Content.ReadAsStringAsync().Result;
                        GetOrderDetails = JsonConvert.DeserializeObject<List<OrderDetail>>(EmpResponse);

                    }
                    return View(GetOrderDetails);
                }
            }
            else
            {
                return RedirectToAction("Login", "UserRegister");
            }
        }
    }
}





