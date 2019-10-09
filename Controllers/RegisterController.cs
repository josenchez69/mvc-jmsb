using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mvc_jmsb.Models;

namespace mvc_jmsb.Controllers
{
    public class RegisterController : Controller
    {
        private readonly mvc_jmsbContext _context;
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(RegisterLogin model, string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            if (ModelState.IsValid)
            {
                if (model.User == "sa" && model.Password == "sa")
                {
                    //    return View(model);                
                    //ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                    //return View(model); 
                    return View("Welcome");
                }
                else
                {
                ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                return View(model);
                }               
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Pailas");
                return View(model);
            }
        }
    }
}