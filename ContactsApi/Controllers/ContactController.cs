using System.Threading.Tasks;
using ContactsApi.Models;
using Microsoft.AspNetCore.Mvc;
using ContactsApi.Services;
using ContactsApi.Models.Requests;

namespace ContactsApi.Controllers
{

    [Route("api/contacts")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        // GET: /api/[controller]?pageNumber=n&pageSize=n
        [HttpGet]
        public async Task<IActionResult> GetContactsPage([FromQuery] PagedListRequest request)
        {
            var contacts = await _contactService.GetContactsPage(request);

            if (contacts == null) {
                return NotFound();
            }

            return Ok(contacts);
        }

        // GET: api/[controller]/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Contact>> GetContactById(int id)
        {
            if (id == 0) {
                return BadRequest();
            }

            var contact = await _contactService.GetContactById(id);

            if (contact == null)
            {
                return NotFound();
            }

            return Ok(contact);
        }

        // GET: api/[controller]/count
        [HttpGet]
        [Route("count")]
        public async Task<ActionResult<int>> GetContactCount()
        {
            var count = await _contactService.GetContactCount();

            return Ok(count);
        }

        // PUT: api/[controller]/5
        [HttpPut("{id}")]
        public async Task<ActionResult> PutContact(Contact contact)
        {
            var result = await _contactService.UpdateContact(contact);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        // POST: api/[controller]
        [HttpPost]
        public async Task<ActionResult<Contact>> PostContact(Contact contact)
        {
            await _contactService.CreateContact(contact);

            return Ok(contact);
        }

        // DELETE: api/[controller]/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteContact(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            var contact = await _contactService.GetContactById(id);

            if (contact == null)
            {
                return NotFound();
            }

            await _contactService.DeleteContact(id);

            return Ok(contact);
        }
    }
}