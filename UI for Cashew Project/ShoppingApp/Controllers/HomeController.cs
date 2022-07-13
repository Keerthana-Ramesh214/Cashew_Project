using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ShoppingApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingApp.Controllers
{
    public class HomeController : Controller
    {
        public static List<ContactUs> contactUs = new List<ContactUs>();
        [HttpGet]
        public IActionResult ContactUs()
        {
            return View();
        }
        public  async Task<IActionResult> ContactUs(ContactUs contact)
        {
            contactUs.Add(new ContactUs(contact));
            ViewBag.success = "Success";
            return View();
        }
        public async Task<IActionResult>  MsgPassing()
        {
            if (contactUs.Count == 0)
            {
                return RedirectToAction("NoMessages");
               
            }
            else
            {
                return View(contactUs);
            }
        }
        public IActionResult NoMessages()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }
    }
}
