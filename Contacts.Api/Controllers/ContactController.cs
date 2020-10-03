using System;
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
            var contact = await _contactService.GetContactById(id);

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
            var result = await _contactService.CreateContact(contact);

            return Ok(result);
        }

        // DELETE: api/[controller]/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteContact(int id)
        {
            var contact = await _contactService.GetContactById(id);

            await _contactService.DeleteContact(id);

            return Ok(contact);
        }
    }
}