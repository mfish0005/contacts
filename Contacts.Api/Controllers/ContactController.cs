using System.Threading.Tasks;
using Contacts.Api.Models;
using Contacts.Api.Models.Requests;
using Contacts.Api.Services;
using Microsoft.AspNetCore.Mvc;
using Contacts.Logger;

namespace Contacts.Api.Controllers
{

    [Route("api/contacts")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;
        
        private readonly ILoggerManager _logger;

        public ContactController(IContactService contactService, ILoggerManager logger)
        {
            _contactService = contactService;
            _logger = logger;
        }

        // GET: /api/[controller]?pageNumber=n&pageSize=n
        [HttpGet]
        public async Task<IActionResult> GetContactsPageAsync([FromQuery] PagedListRequest request)
        {
            var result = await _contactService.GetContactsPageAsync(request);

            return Ok(result);
        }

        // GET: api/[controller]/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Contact>> GetContactByIdAsync(int id)
        {
            var result = await _contactService.GetContactByIdAsync(id);

            return Ok(result);
        }

        // GET: api/[controller]/count
        [HttpGet]
        [Route("count")]
        public async Task<ActionResult<int>> GetContactCountAsync()
        {
            var result = await _contactService.GetContactCountAsync();

            return Ok(result);
        }

        // PUT: api/[controller]/5
        [HttpPut("{id}")]
        public async Task<ActionResult> PutContactAsync(int id, Contact contact)
        {
            var result = await _contactService.UpdateContactAsync(contact);

            return Ok(result);
        }

        // POST: api/[controller]
        [HttpPost]
        public async Task<ActionResult<Contact>> PostContactAsync(Contact contact)
        {
            var result = await _contactService.CreateContactAsync(contact);

            return Ok(result);
        }

        // DELETE: api/[controller]/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteContactAsync(int id)
        {
            var result = await _contactService.DeleteContactAsync(id);

            return Ok(result);
        }
    }
}