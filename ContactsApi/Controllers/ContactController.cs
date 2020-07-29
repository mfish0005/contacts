using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ContactsApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactsApi.Controllers
{

    [Route("api/contacts")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly ContactsContext _context;
        private readonly IContactRepository<Contact> _repository;

        public ContactsController(ContactsContext context, IContactRepository<Contact> repository)
        {
            _context = context;
            _repository = repository;
        }

        // GET: /api/contacts?pageNumber=n&pageSize=n
        [HttpGet]
        public IActionResult GetContacts([FromQuery] ContactParameters contactParameters)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var contacts = _repository.GetContacts(contactParameters);

            return Ok(contacts);
        }

        // GET: /api/contacts/count
        [HttpGet]
        [Route("count")]
        public IActionResult GetContactCount()
        {
            var count = _context.Contacts.Count();

            return Ok(count);
        }

        // GET: /api/contacts/id
        [HttpGet("{id}")]
        public async Task<ActionResult<Contact>> GetContact([FromRoute] int id)
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

        // POST: /api/contacts
        [HttpPost]        
        public async Task<ActionResult<Contact>> PostContact([FromBody] Contact contact)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _repository.Add(contact);

            await _repository.SaveAsync(contact);

            return CreatedAtAction("GetContact", new { id = contact.Id }, contact);
        }

        // PUT: /api/contacts/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutContact([FromRoute] int id, [FromBody] Contact contact)
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
                _repository.Update(contact);

                var save = await _repository.SaveAsync(contact);
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

        // DELETE: /api/contacts
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
                _repository.Delete(contact);

                await _repository.SaveAsync(contact);

                return Ok(contact);
            } else
            {
                return NotFound();
            }
        }
    }
}