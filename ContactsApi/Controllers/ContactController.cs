using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ContactsApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ContactsApi.Controllers
{

    [Route("contacts")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly ContactsApiContext _context;

        public ContactsController(ContactsApiContext context)
        {
            _context = context;

            if (_context.Contacts.Count() == 0)
            {
                //If db is empty then initialize it
                _context.Contacts.Add(new Contact
                {
                    Id = 1,
                    Name = "Bob Johnson",
                    Email = "bob@dbinitializer.com",
                });
                
                _context.SaveChanges();
            }
        }

        // GET: /Contacts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Contact>>> GetContacts()
        {
            return await _context.Contacts.ToListAsync();
        }

        // GET: /contacts/1
        [HttpGet("{id}")]
        public async Task<ActionResult<Contact>> GetContact(int id)
        {
            var contact = await _context.Contacts.FindAsync(id);

            if (contact == null)
            {
                return NotFound();
            }

            return contact;
        }

        // POST: /contacts/post
        [HttpPost]
        [Route("post")]
        public async Task<ActionResult<Contact>> PostContact(Contact contact)
        {
            _context.Contacts.Add(contact);

            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetContact), new { id = contact.Id }, contact);
        }
    }
}