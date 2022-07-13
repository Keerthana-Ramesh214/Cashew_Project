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
    public class UserDetailsController : ControllerBase
    {
        
            private readonly ShoppingContext _context;

            public UserDetailsController(ShoppingContext context)
            {
                _context = context;
            }

            // GET: api/ShoppingCarts
            [HttpGet]
            public async Task<ActionResult<IEnumerable<UserRegistration>>> GetUserDetails()
            {
                return await _context.UserRegistrations.ToListAsync();
            }

            // GET: api/ShoppingCarts/5
            [HttpGet("{id}")]
            public async Task<ActionResult<UserRegistration>> GetUserDetails(long id)
            {
                var Udetails = await _context.UserRegistrations.FindAsync(id);

                if (Udetails == null)
                {
                    return NotFound();
                }

                return Udetails;
            }

            // PUT: api/ShoppingCarts/5
            // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
            [HttpPut("{id}")]
            public async Task<IActionResult> PutUserDetails(long id, UserRegistration Udetails)
            {
                if (id != Udetails.PhoneNumber)
                {
                    return BadRequest();
                }

                _context.Entry(Udetails).State = EntityState.Modified;

                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserRegistrationExist(id))
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

            // POST: api/ShoppingCarts
            // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
            [HttpPost]
            public async Task<ActionResult<UserRegistration>> PostUserDetails(UserRegistration Udetails)
            {
                _context.UserRegistrations.Add(Udetails);
                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateException)
                {
                    if (UserRegistrationExist(Udetails.PhoneNumber))
                    {
                        return Conflict();
                    }
                    else
                    {
                        throw;
                    }
                }

                return CreatedAtAction("GetUserDetails", new { id = Udetails.PhoneNumber }, Udetails);
            }

            // DELETE: api/ShoppingCarts/5
            [HttpDelete("{id}")]
            public async Task<IActionResult> DeleteUserDetails(int id)
            {
                var udetails = await _context.UserRegistrations.FindAsync(id);
                if (udetails == null)
                {
                    return NotFound();
                }

                _context.UserRegistrations.Remove(udetails);
                await _context.SaveChangesAsync();

                return NoContent();
            }

            private bool UserRegistrationExist(long id)
            {
                return _context.UserRegistrations.Any(e => e.PhoneNumber == id);
            }
        }
    }

