using System.Threading.Tasks;
using Contacts.Api.Models;
using Contacts.Api.Models.Requests;
using Contacts.Api.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Contacts.Api.Controllers
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
        [Authorize]
        public async Task<IActionResult> GetContactsPageAsync([FromQuery] PagedListRequest request)
        {
            var result = await _contactService.GetContactsPageAsync(request);

            return Ok(result);
        }

        // GET: api/[controller]/5
        [HttpGet("{id}")]
        [Authorize]
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
        [Authorize]
        public async Task<ActionResult> PutContactAsync(int id, Contact contact)
        {
            var result = await _contactService.UpdateContactAsync(contact);

            return Ok(result);
        }

        // POST: api/[controller]
        [HttpPost]
        [Authorize]
        public async Task<ActionResult<Contact>> PostContactAsync(Contact contact)
        {
            var result = await _contactService.CreateContactAsync(contact);

            return Ok(result);
        }

        // DELETE: api/[controller]/5
        [HttpDelete("{id}")]
        [Authorize]
        public async Task<ActionResult> DeleteContactAsync(int id)
        {
            var result = await _contactService.DeleteContactAsync(id);

            return Ok(result);
        }
    }
}