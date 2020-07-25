using Microsoft.EntityFrameworkCore;

namespace ContactsApi.Models
{
    public class ContactsApiContext : DbContext
    {
        public ContactsApiContext(DbContextOptions<ContactsApiContext> options) : base(options)
        {

        }

        public DbSet<Contact> Contacts { get; set; }
    }
}
