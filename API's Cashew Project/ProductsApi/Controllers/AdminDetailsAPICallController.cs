using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ProductsApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ProductsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminDetailsAPICallController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAdminDetails()
        {
            List<AdminDetail> admindet = new List<AdminDetail>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44351/");
                HttpResponseMessage response = await client.GetAsync("api/AdminDetails");

                var AdminResponse = response.Content.ReadAsStringAsync().Result;
                admindet = JsonConvert.DeserializeObject<List<AdminDetail>>(AdminResponse);
                response.EnsureSuccessStatusCode();
                return Ok(admindet);
            }
        }
    }

}
