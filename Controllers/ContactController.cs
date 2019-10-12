using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mime;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using mvc_jmsb.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace mvc_jmsb.Controllers
{
    [Route("api/[controller]")]
    public class ContactController : Controller
    {
        // POST api/values
        [HttpPost]
        [Consumes(MediaTypeNames.Application.Json)]  
        public void Post([FromBody]Contact contact)
        {
           
        }
    }
}
