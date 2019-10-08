using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mvc_jmsb.Models.ViewModels;
using mvc_jmsb.Services;

namespace mvc_jmsb.Controllers
{
    public class RegisterController : Controller
    {
        private readonly JMSBValidation _ezAuth;
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(RegisterLogin model, string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
           // if (ModelState.IsValid)
           // {
                if (model.User == "sa" && model.Password == "sa")
                {
                    return View(model);                
                }
                else
                {
                ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                return View(model);
                }
            /*var loggedIn = _ezAuth.SignIn(model.User, model.Password);
                if (loggedIn)
                {
                    return View(model);
                    //return RedirectToLocal(returnUrl);
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                    return View(model);
                }
          //  }
          
            return View(model);*/
        }
    }
}