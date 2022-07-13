using Castle.Core.Smtp;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ShoppingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Controllers
{
    public class AdminController : Controller
    {


        [HttpGet]
        public IActionResult LoggingIn()
        {
            return View();
        }

        public async Task<ActionResult> LoggingIn(AdminDetails admin)
        {
            List<AdminDetails> AdminDtls = new List<AdminDetails>();
            string Baseurl = "https://localhost:44382/";
            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri(Baseurl);

                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage Res = await client.GetAsync("api/AdminDetailsAPICall");

                if (Res.IsSuccessStatusCode)
                {
                    var SCResponse = Res.Content.ReadAsStringAsync().Result;

                    AdminDtls = JsonConvert.DeserializeObject<List<AdminDetails>>(SCResponse);

                }
                if (AdminDtls.Any(model => model.AdminName == admin.AdminName))
                {
                    HttpContext.Session.SetString("Admin", Convert.ToString(admin.AdminName));
                    return RedirectToAction("AdminDashboard");
                }
                else
                {
                    return View();
                }
            }
        }

        public async Task<IActionResult> AdminDashboard()
        {
            string AdminName = HttpContext.Session.GetString("Admin");
            if (AdminName != null)
            {
                string Baseurl = "https://localhost:44382/";
                List<Product> ProdDetails = new List<Product>();
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(Baseurl);

                    client.DefaultRequestHeaders.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage Res = await client.GetAsync("api/Products");
                    if (Res.IsSuccessStatusCode)
                    {
                        var EmpResponse = Res.Content.ReadAsStringAsync().Result;

                        ProdDetails = JsonConvert.DeserializeObject<List<Product>>(EmpResponse);
                    }
                    return View(ProdDetails);

                }
            }
            else
            {
                return RedirectToAction("LoggingIn");
            }
        }

        public async Task<IActionResult> CustomerDetails()
        {
            string AdminName = HttpContext.Session.GetString("Admin");
            if (AdminName != null)
            {
                string Baseurl = "https://localhost:44309/";
                List<UserRegistration> AllUsers = new List<UserRegistration>();

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(Baseurl);

                    client.DefaultRequestHeaders.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    HttpResponseMessage Res = await client.GetAsync("/api/UserDetails");

                    if (Res.IsSuccessStatusCode)
                    {
                        var UDResponse = Res.Content.ReadAsStringAsync().Result;

                        AllUsers = JsonConvert.DeserializeObject<List<UserRegistration>>(UDResponse);

                    }
                    return View(AllUsers);
                }
            }
            else
            {
                return RedirectToAction("LoggingIn");
            }
        }

        public async Task<IActionResult> OrderDetails()
        {
            string AdminName = HttpContext.Session.GetString("Admin");
            if (AdminName != null)
            {
                string Baseurl = "https://localhost:44309/";
                List<OrderDetail> AllOrders = new List<OrderDetail>();

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(Baseurl);
                    client.DefaultRequestHeaders.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    HttpResponseMessage Res = await client.GetAsync("/api/OrderDetails");

                    if (Res.IsSuccessStatusCode)
                    {
                        var OrdersResponse = Res.Content.ReadAsStringAsync().Result;

                        AllOrders = JsonConvert.DeserializeObject<List<OrderDetail>>(OrdersResponse);

                    }
                    return View(AllOrders);
                }
            }
            else
            {
                return RedirectToAction("LoggingIn");
            }
        }
        [HttpGet]
        public async Task<IActionResult> CreateProduct()
        {
            string AdminName = HttpContext.Session.GetString("Admin");
            if (AdminName != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("LoggingIn");
            }
        }
        [HttpPost]
        public async Task<ActionResult> CreateProduct(Product p)
        {
            string AdminName = HttpContext.Session.GetString("Admin");
            if (AdminName != null)
            {
                Product ProdObj = new Product();
                using (var httpClient = new HttpClient())
                {
                    StringContent content = new StringContent(JsonConvert.SerializeObject(p), Encoding.UTF8, "application/json");

                    using (var response = await httpClient.PostAsync("https://localhost:44382/api/Products", content))
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        ProdObj = JsonConvert.DeserializeObject<Product>(apiResponse);
                    }
                }
                return RedirectToAction("AdminDashboard");
            }
            else
            {
                return RedirectToAction("LoggingIn");
            }
        }


        [HttpGet]
        public async Task<ActionResult> UpdateProducts(int id)
        {
            string AdminName = HttpContext.Session.GetString("Admin");
            if (AdminName != null)
            {
                Product p = new Product();
                using (var httpClient = new HttpClient())
                {
                    using (var response = await httpClient.GetAsync("https://localhost:44382/api/Products/GetProdById" + id))
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        p = JsonConvert.DeserializeObject<Product>(apiResponse);
                    }
                }
                return View(p);
            }
            else
            {
                return RedirectToAction("LoggingIn");
            }
        }

        [HttpPost]
        public async Task<ActionResult> UpdateProducts(Product p)
        {
            string AdminName = HttpContext.Session.GetString("Admin");
            if (AdminName != null)
            {
                Product receivedemp = new Product();

                using (var httpClient = new HttpClient())
                {
                    int id = p.ProductId;
                    StringContent content1 = new StringContent(JsonConvert.SerializeObject(p), Encoding.UTF8, "application/json");
                    using (var response = await httpClient.PutAsync("https://localhost:44382/api/Products?id=" + id, content1))
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        ViewBag.Result = "Success";
                        receivedemp = JsonConvert.DeserializeObject<Product>(apiResponse);
                    }
                }
                return RedirectToAction("AdminDashboard");
            }
            else
            {
                return RedirectToAction("LoggingIn");
            }
        }

        [HttpGet]
        public async Task<ActionResult> DeleteProduct(int id)
        {
            string AdminName = HttpContext.Session.GetString("Admin");
            if (AdminName != null)
            {
                TempData["Productid"] = id;
                Product p = new Product();
                using (var httpClient = new HttpClient())
                {
                    using (var response = await httpClient.GetAsync("https://localhost:44382/api/Products/GetProdById" + id))
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        p = JsonConvert.DeserializeObject<Product>(apiResponse);
                    }
                }
                return View(p);
            }
            else
            {
                return RedirectToAction("LoggingIn");
            }
        }


        [HttpPost]
        public async Task<ActionResult> DeleteProduct(Product p)
        {
            string AdminName = HttpContext.Session.GetString("Admin");
            if (AdminName != null)
            {
                int PdtId = Convert.ToInt32(TempData["Productid"]);
                using (var httpClient = new HttpClient())
                {
                    using (var response = await httpClient.DeleteAsync("https://localhost:44382/api/Products?id=" + PdtId))
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                    }
                }

                return RedirectToAction("AdminDashboard");
            }
            else
            {
                return RedirectToAction("LoggingIn");
            }
        }

        public async Task<ActionResult> Loggingout()
        {
            HttpContext.Session.SetString("Admin", Convert.ToString(0));
            return RedirectToAction("Index", "Products");
        }

    }
}

