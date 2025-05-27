using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication9.Models;

namespace WebApplication9.Data
{
    public class ContactData : DbContext
    {
        public ContactData (DbContextOptions<ContactData> options)
            : base(options)
        {
        }

        public DbSet<WebApplication9.Models.Contact> Contact { get; set; } = default!;
    }
}
