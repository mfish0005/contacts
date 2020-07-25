using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ContactsApi.Models;
using Microsoft.EntityFrameworkCore;

namespace GrayfishAPI.Controllers
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
                    Name = "Uncle D.b. Initializer",
                    Email = "db@db.com",                    
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
            //Added the contact to the context
            _context.Contacts.Add(contact);

            //Save the context
            await _context.SaveChangesAsync();            

            //Return the response            
            return CreatedAtAction(nameof(GetContact), new { id = contact.Id }, contact);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            //Find the contact
            var contact = _context.Contacts.Find(id);

            //Make sure the contact exists
            if (contact != null)
            {
                //Delete it
                _context.Contacts.Remove(_context.Contacts.Find(contact.Id));

                //Save the context
                _context.SaveChanges();
            }
        }
    }
}