using System.IO;
using ContactsApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Resources;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ContactsApi.Data.Orm.EfCore
{
    public class ContactsContext : DbContext
    {
        public ContactsContext(DbContextOptions<ContactsContext> options) : base(options)
        {

        }

        public DbSet<Contact> Contacts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Note: For Postgres to auto generate entity ids it requires seed data to use negative ids
            var path = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/contacts.json");
            var json = File.ReadAllText(path);

            List<Contact> contacts = JsonConvert.DeserializeObject<List<Contact>>(json);
            modelBuilder.Entity<Contact>().HasData(contacts);
        }
    }
}