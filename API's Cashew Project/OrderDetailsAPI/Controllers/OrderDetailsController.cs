using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrderDetailsAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderDetailsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderDetailsController : ControllerBase
    {
        private readonly ShoppingContext _context;

        public OrderDetailsController(ShoppingContext context)
        {
            _context = context;
        }

        // GET: api/ShoppingCarts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OrderDetail>>> GetOrderDetails()
        {
            return await _context.OrderDetails.ToListAsync();
        }

        // GET: api/ShoppingCarts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<OrderDetail>> GetOrderDetails(int id)
        {
            var OrdDet = await _context.OrderDetails.FindAsync(id);

            if (OrdDet == null)
            {
                return NotFound();
            }

            return Ok(OrdDet);
        }


        [HttpGet("Customer/{CusMobNo}")]
        public async Task<ActionResult<List<OrderDetail>>> GetOrderDetails(long CusMobNo)
        {
            dynamic res = 0;
            var OrdDetail = from OrdDet in _context.OrderDetails select OrdDet;
            if (CusMobNo != 0)
            {
                res=OrdDetail.Where(m => m.CustomerMobNo == CusMobNo);
            }
            return Ok(res);
        }

        // PUT: api/ShoppingCarts/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrderDetails(int id, OrderDetail OrdDet)
        {
            if (id != OrdDet.OrderId)
            {
                return BadRequest();
            }

            _context.Entry(OrdDet).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrderDetailsExist(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }
        [HttpPost]
        public async Task<ActionResult<OrderDetail>> PostOrderdetails(OrderDetail OrdDet)
        {
            _context.OrderDetails.Add(OrdDet);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (OrderDetailsExist(OrdDet.OrderId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetUserDetails", new { id = OrdDet.OrderId }, OrdDet);
        }

        // DELETE: api/ShoppingCarts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrderdetails(int id)
        {
            var orderDetail = await _context.OrderDetails.FindAsync(id);
            if (orderDetail == null)
            {
                return NotFound();
            }
            _context.OrderDetails.Remove(orderDetail);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool OrderDetailsExist(int id)
        {
            return _context.OrderDetails.Any(e => e.OrderId == id);
        }

        
    }
    

}

