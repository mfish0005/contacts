using Microsoft.EntityFrameworkCore;

namespace ContactsApi.Models
{
    public class ContactsApiContext: DbContext {
        public ContactsApiContext(DbContextOptions<ContactsApiContext> options) : base(options)
        {

        }

        public DbSet<Contact> Contacts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Contact>().HasData(
                new { Id = 1, Name = "Bob Johnson", Email = "bob@bob.com" },
                new { Id = 2, Name = "Lucy Liu", Email = "bob@bob.com" },
                new { Id = 3, Name = "Robert Redford", Email = "bob@bob.com" },
                new { Id = 4, Name = "Lucy Liu", Email = "bob@bob.com" },
                new { Id = 5, Name = "Robert Redford", Email = "bob@bob.com" },
                new { Id = 6, Name = "Lucy Liu", Email = "bob@bob.com" },
                new { Id = 7, Name = "Robert Redford", Email = "bob@bob.com" },
                new { Id = 8, Name = "Lucy Liu", Email = "bob@bob.com" },
                new { Id = 9, Name = "Robert Redford", Email = "bob@bob.com" },
                new { Id = 10, Name = "Bob Johnson", Email = "bob@bob.com" },
                new { Id = 11, Name = "Bob Johnson", Email = "bob@bob.com" },
                new { Id = 12, Name = "Lucy Liu", Email = "bob@bob.com" },
                new { Id = 13, Name = "Robert Redford", Email = "bob@bob.com" },
                new { Id = 14, Name = "Lucy Liu", Email = "bob@bob.com" },
                new { Id = 15, Name = "Robert Redford", Email = "bob@bob.com" },
                new { Id = 16, Name = "Lucy Liu", Email = "bob@bob.com" },
                new { Id = 17, Name = "Robert Redford", Email = "bob@bob.com" },
                new { Id = 18, Name = "Lucy Liu", Email = "bob@bob.com" },
                new { Id = 19, Name = "Robert Redford", Email = "bob@bob.com" },
                new { Id = 20, Name = "Bob Johnson", Email = "bob@bob.com" },
                new { Id = 21, Name = "Lucy Liu", Email = "bob@bob.com" },
                new { Id = 22, Name = "Robert Redford", Email = "bob@bob.com" },
                new { Id = 23, Name = "Lucy Liu", Email = "bob@bob.com" },
                new { Id = 24, Name = "Robert Redford", Email = "bob@bob.com" },
                new { Id = 26, Name = "Lucy Liu", Email = "bob@bob.com" },
                new { Id = 27, Name = "Robert Redford", Email = "bob@bob.com" },
                new { Id = 28, Name = "Lucy Liu", Email = "bob@bob.com" },
                new { Id = 29, Name = "Robert Redford", Email = "bob@bob.com" },
                new { Id = 30, Name = "Bob Johnson", Email = "bob@bob.com" },
                new { Id = 31, Name = "Robert Redford", Email = "bob@bob.com" },
                new { Id = 32, Name = "Lucy Liu", Email = "bob@bob.com" },
                new { Id = 33, Name = "Robert Redford", Email = "bob@bob.com" },
                new { Id = 34, Name = "Lucy Liu", Email = "bob@bob.com" },
                new { Id = 35, Name = "Robert Redford", Email = "bob@bob.com" },
                new { Id = 36, Name = "Lucy Liu", Email = "bob@bob.com" },
                new { Id = 37, Name = "Robert Redford", Email = "bob@bob.com" },
                new { Id = 38, Name = "Lucy Liu", Email = "bob@bob.com" },
                new { Id = 39, Name = "Robert Redford", Email = "bob@bob.com" },
                new { Id = 40, Name = "Bob Johnson", Email = "bob@bob.com" },
                new { Id = 41, Name = "Robert Redford", Email = "bob@bob.com" },
                new { Id = 42, Name = "Lucy Liu", Email = "bob@bob.com" },
                new { Id = 43, Name = "Robert Redford", Email = "bob@bob.com" },
                new { Id = 44, Name = "Lucy Liu", Email = "bob@bob.com" },
                new { Id = 45, Name = "Robert Redford", Email = "bob@bob.com" },
                new { Id = 46, Name = "Lucy Liu", Email = "bob@bob.com" },
                new { Id = 47, Name = "Robert Redford", Email = "bob@bob.com" },
                new { Id = 48, Name = "Lucy Liu", Email = "bob@bob.com" },
                new { Id = 49, Name = "Robert Redford", Email = "bob@bob.com" },
                new { Id = 50, Name = "Bob Johnson", Email = "bob@bob.com" },
                new { Id = 51, Name = "Robert Redford", Email = "bob@bob.com" },
                new { Id = 52, Name = "Lucy Liu", Email = "bob@bob.com" },
                new { Id = 53, Name = "Robert Redford", Email = "bob@bob.com" },
                new { Id = 54, Name = "Lucy Liu", Email = "bob@bob.com" },
                new { Id = 55, Name = "Robert Redford", Email = "bob@bob.com" },
                new { Id = 56, Name = "Lucy Liu", Email = "bob@bob.com" },
                new { Id = 57, Name = "Robert Redford", Email = "bob@bob.com" },
                new { Id = 58, Name = "Lucy Liu", Email = "bob@bob.com" },
                new { Id = 59, Name = "Robert Redford", Email = "bob@bob.com" },
                new { Id = 60, Name = "Bob Johnson", Email = "bob@bob.com" },
                new { Id = 61, Name = "Lucy Liu", Email = "bob@bob.com" },
                new { Id = 62, Name = "Lucy Liu", Email = "bob@bob.com" },
                new { Id = 63, Name = "Robert Redford", Email = "bob@bob.com" },
                new { Id = 64, Name = "Lucy Liu", Email = "bob@bob.com" },
                new { Id = 65, Name = "Robert Redford", Email = "bob@bob.com" },
                new { Id = 66, Name = "Lucy Liu", Email = "bob@bob.com" },
                new { Id = 67, Name = "Robert Redford", Email = "bob@bob.com" },
                new { Id = 68, Name = "Lucy Liu", Email = "bob@bob.com" },
                new { Id = 69, Name = "Robert Redford", Email = "bob@bob.com" },
                new { Id = 70, Name = "Bob Johnson", Email = "bob@bob.com" },               
                new { Id = 71, Name = "Lucy Liu", Email = "bob@bob.com" },
                new { Id = 72, Name = "Robert Redford", Email = "bob@bob.com" });
        }
    }
}