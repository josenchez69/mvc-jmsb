using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using mvc_jmsb.Models;

namespace mvc_jmsb.Controllers
{
    /*[Route("api/[controller]")]
    [ApiController]*/
    [Authorize]
    public class ContactsController : Controller
    {
        private readonly mvc_jmsbContext _context;
        
        public ContactsController(mvc_jmsbContext context)
        {
            _context = context;
        }
        
        [HttpGet]
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }
        /* 
        // GET: api/Contacts/5
        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<ActionResult<Contact>> GetContact(int id)
        {
            var contact = await _context.Contact.FindAsync(id);

            if (contact == null)
            {
                return NotFound();
            }

            return contact;
        }
        */
        // POST: api/Contacts
        [HttpPost]
        [AllowAnonymous]
        public IActionResult Index(Contact contact)
        {
            _context.Contact.Add(contact);
            _context.SaveChangesAsync();
           return View("Thanks");
        //   return CreatedAtAction("GetContact", new { id = contact.Id }, contact);
        }

       

        private bool ContactExists(int id)
        {
            return _context.Contact.Any(e => e.Id == id);
        }
    }
}
