using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductsApi.Models;
using ProductsApi.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IServiceRepo<Product> prodservices;
        public ProductsController(IServiceRepo<Product> ps)
        {
            prodservices = ps;
        }
        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            prodservices.getAllProduct();
            return Ok(prodservices.getAllProduct());
        }
        [HttpPost]
        public async Task<ActionResult> AddProduct(Product p)
        {
            prodservices.AddProduct(p);
            return Ok(p);
        }
        [HttpGet]
        [Route("GetProdById{id}")]
        public async Task<ActionResult<Product>> getprodbyId(int id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            Product p = prodservices.getProdById(id);
            if (p == null)
            {
                return NotFound();
            }
            return Ok(p);
        }

        [HttpPut]
        public async Task<ActionResult> UpdateProducts(int id, Product p)
        {
            prodservices.EditProduct(p,id);
            return Ok();
        }
        [HttpDelete]

        public async Task<ActionResult> DeleteProduct(int id)
        {
            prodservices.DeleteProduct(id);
            return Ok();
        }
    }
}


