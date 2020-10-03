using System.IO;
using Microsoft.EntityFrameworkCore;
using System.Resources;
using Newtonsoft.Json;
using System.Collections.Generic;
using Contacts.Api.Models;

namespace Contacts.Api.Data.EfCore
{
    public class ContactsContext : DbContext
    {
        public ContactsContext(DbContextOptions<ContactsContext> options) : base(options)
        {

        }

        public DbSet<Contact> Contacts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Note: Postgres will only auto generate ids if seed data uses negative ids
            var path = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/contacts.json");
            var json = File.ReadAllText(path);

            List<Contact> contacts = JsonConvert.DeserializeObject<List<Contact>>(json);
            modelBuilder.Entity<Contact>().HasData(contacts);
        }
    }
}