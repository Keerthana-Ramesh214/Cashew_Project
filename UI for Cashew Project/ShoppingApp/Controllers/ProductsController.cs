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
    public class ProductsController : Controller
    {
        string Baseurl = "https://localhost:44382/";
        List<Product> ProdDetails = new List<Product>();
            public async Task<ActionResult> Index()
            {

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
        public async Task<IActionResult> GetProductDetails(int id)
        {
            Product sc = new Product();
            using (var httpClient = new HttpClient())
            {
                try
                {
                    using (var response = await httpClient.GetAsync("https://localhost:44382/api/Products/GetProdById" +id))
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        sc = JsonConvert.DeserializeObject<Product>(apiResponse);
                    }
                }
                catch (Exception)
                {
                    return View("ServerNotFound");
                }
            }
            ViewBag.ImageUrl = sc.ProductImage;
            return View(sc);
        }

    }
}

