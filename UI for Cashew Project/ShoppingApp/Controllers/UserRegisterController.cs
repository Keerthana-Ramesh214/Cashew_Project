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
    public class UserRegisterController:Controller
    {
        [HttpGet]
        public async Task<ActionResult> Login()
        {
                return View();
        }

        public async Task<ActionResult> Login(UserRegistration user)
        {
            UserRegistration ur = new UserRegistration();
            using (var httpClient = new HttpClient())
            {
                try
                {
                    using (var response = await httpClient.GetAsync("https://localhost:44309/api/UserDetails/" + user.PhoneNumber))
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        ur = JsonConvert.DeserializeObject<UserRegistration>(apiResponse);
                        HttpContext.Session.SetString("UserFirstName", Convert.ToString(ur.FirstName));
                        
                    }
                }
                catch (Exception)
                {
                    return View("ServerNotFound");
                }
            }
            HttpContext.Session.SetString("UserNum", Convert.ToString(ur.PhoneNumber));
            if (ur.PhoneNumber == user.PhoneNumber)
            {
                  return RedirectToAction("Index", "Products");
            }
            else
            {
                return View();
            }
        }

        public  IActionResult AddUser()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> AddUser(UserRegistration user)
        {
            
            UserRegistration userObj = new UserRegistration();

            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json");

                using (var response = await httpClient.PostAsync("https://localhost:44309/api/UserDetails", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    userObj = JsonConvert.DeserializeObject<UserRegistration>(apiResponse);
                }

            }
            return RedirectToAction("RegisteredSuccessfully");
        }

        public IActionResult RegisteredSuccessfully()
        {
            return View();
        }
        [HttpGet]
        public IActionResult ForgotPassword()
        {
            return View();
        }

        public async Task<IActionResult> ForgotPassword(UserRegistration user)
        {
            UserRegistration ur = new UserRegistration();
            using (var httpClient = new HttpClient())
            {
                try
                {
                    using (var response = await httpClient.GetAsync("https://localhost:44309/api/UserDetails/" + user.PhoneNumber))
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        ur = JsonConvert.DeserializeObject<UserRegistration>(apiResponse);
                        HttpContext.Session.SetString("UserFirstName", Convert.ToString(ur.FirstName));
                        HttpContext.Session.SetString("UserNum", Convert.ToString(ur.PhoneNumber));
                    }
                }
                catch (Exception)
                {
                    return View("ServerNotFound");
                }
            }
            if(user.UserName == ur.UserName && user.PhoneNumber==ur.PhoneNumber && user.Dob == ur.Dob)
            {
                ViewBag.PassWord = ur.Password;
                return RedirectToAction("DisplayPassword", new { Password = ViewBag.PassWord });
            }
            else
            {
                return RedirectToAction("WrongDetails");
            }

        }

        public IActionResult WrongDetails()
        {
            return View();
        }
        public IActionResult DisplayPassword(string Password)
        {
            ViewBag.PW = Password;
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.SetString("UserNum", Convert.ToString(0));
            return RedirectToAction("Index", "Products");
        }

    }
}
