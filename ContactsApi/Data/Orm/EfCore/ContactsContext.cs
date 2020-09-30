using ContactsApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactsApi.Data.Orm.EfCore
{
    public class ContactsContext : DbContext 
    {
        public ContactsContext(DbContextOptions<ContactsContext> options) : base(options)
        {

        }

        public DbSet<Contact> Contacts { get; set; }

        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
        //     // For demo purposes only.  Not a production seeding solution lol
        //     for (var i = -500; i < 0; i++)
        //     {
        //         // Also just found out on postgres's Github that postgres won't auto generate id's 
        //         // if EF Core seeds with positive id's
        //         modelBuilder.Entity<Contact>().HasData(
        //             new { Id = i, Name = "Uncle Bob", Email = "uncle@bob.com", Phone = "123-444-1337", Address = "31 Clean Code Lane" });
        //     }
        // }
    }
}