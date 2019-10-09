using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace mvc_jmsb.Models
{
    public class Contact
    {
        public int Id { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [Phone]
        public string Phone { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string City { get; set; }
    }
}
