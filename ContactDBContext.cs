using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ContactManagement.Models
{
    public class ContactDBContext : DbContext
    {
        public ContactDBContext(DbContextOptions<ContactDBContext> options) : base(options) { }

        public DbSet<Contact> Contacts { get; set; }
    }
}
