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
                if (model.User == "user" && model.Password == "1234")
                {
                    return View("Welcome");
                }
                else
                {
                ModelState.AddModelError(string.Empty, "Por favor verifique su usuario y password que alguno no es el correcto");
                return View(model);
                }               
            }
            else
            {
                ModelState.AddModelError(string.Empty, "No se pudo validar, intente mas tarde");
                return View(model);
            }
        }
    }
}