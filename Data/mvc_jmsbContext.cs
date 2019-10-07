using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace mvc_jmsb.Models
{
    public class mvc_jmsbContext : DbContext
    {
        public mvc_jmsbContext (DbContextOptions<mvc_jmsbContext> options)
            : base(options)
        {
        }

        public DbSet<mvc_jmsb.Models.Contact> Contact { get; set; }
    }
}
