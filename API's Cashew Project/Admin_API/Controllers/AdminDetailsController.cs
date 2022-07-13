using Admin_API.Models;
using Admin_API.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Admin_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class AdminDetailsController : ControllerBase
    {
         private readonly IServiceAdmin<AdminDetail> AdminSerive;
         public AdminDetailsController(IServiceAdmin<AdminDetail> Ad)
         {
            AdminSerive = Ad;
         }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AdminDetail>>> GetAdminDetails()
        {
            AdminSerive.getAdmin();
            return Ok(AdminSerive.getAdmin());
        }
    }
}
 