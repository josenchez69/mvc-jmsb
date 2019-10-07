using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace mvc_jmsb.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}