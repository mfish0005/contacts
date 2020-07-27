using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ContactsApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.AspNetCore.Cors;

namespace ContactsApi.Controllers
{

    [Route("contacts")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly ContactsApiContext _context;
        private readonly IContactRepository<Contact> _repo;

        public ContactsController(ContactsApiContext context, IContactRepository<Contact> repo)
        {
            _context = context;
            _repo = repo;
        }

        // GET: /contacts
        [HttpGet]        
        public async Task<ActionResult<IEnumerable<Contact>>> GetContacts()
        {            
            return await _context.Contacts.ToListAsync();
        }

        // GET: /contacts/1
        [HttpGet("{id}")]
        public async Task<ActionResult<Contact>> GetContact(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var contact = await _context.Contacts.FindAsync(id);

            if (contact == null)
            {
                return NotFound();
            }

            return Ok(contact);
        }

        // POST: /contacts
        [HttpPost]        
        public async Task<ActionResult<Contact>> PostContact(Contact contact)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _repo.Add(contact);

            await _repo.SaveAsync(contact);

            return CreatedAtAction("GetContact", new { id = contact.Id }, contact);
        }

        // PUT: contacts/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutContact(int id, Contact contact)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != contact.Id)
            {
                return BadRequest();
            }

            _context.Entry(contact).State = EntityState.Modified;

            try
            {
                _repo.Update(contact);

                var save = await _repo.SaveAsync(contact);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Contacts.Any(e => e.Id == id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetContact", new { id = contact.Id }, contact);
        }

        // DELETE: /contacts
        [HttpDelete("{id}")]
        public async Task<ActionResult<Contact>> DeleteContact(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var contact = await _context.Contacts.FindAsync(id);
            
            if (contact != null)
            {
                _repo.Delete(contact);

                await _repo.SaveAsync(contact);

                return Ok(contact);
            } else
            {
                return NotFound();
            }
        }
    }
}