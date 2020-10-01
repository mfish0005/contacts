using System.Threading.Tasks;
using ContactsApi.Data;
using ContactsApi.Models;
using ContactsApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace ContactsApi.Controllers
{
    [Microsoft.AspNetCore.Components.Route("api/[controller]")]
    [ApiController]
    public abstract class ContactsApiController<TEntity, TRepository> : ControllerBase
        where TEntity : class, IEntity
        where TRepository : IRepository<TEntity>
    {
        private readonly TRepository _repository;
        private readonly IContactService _contactService;

        protected ContactsApiController(TRepository repository, IContactService contactService)
        {
            _repository = repository;
            _contactService = contactService;
        }

        // GET: /api/[controller]?pageNumber=n&pageSize=n
        [HttpGet]
        public async Task<IActionResult> GetContactsPage([FromQuery] int pageNumber, int pageSize)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            PagedList<Contact> result = await _contactService.GetContactsPage(pageNumber, pageSize);

            return Ok(result);
        }

        // GET: api/[controller]/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Contact>> GetContactById(int id)
        {
            Contact contact = await _contactService.GetContactById(id);

            if (contact == null)
            {
                return NotFound();
            }

            return contact;
        }

        // GET: api/[controller]/count
        [HttpGet]
        [Route("count")]
        public async Task<ActionResult<int>> GetContactCount()
        {
            int count = await _contactService.GetContactCount();

            return count;
        }

        // PUT: api/[controller]/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, Contact contact)
        {
            if (id != contact.Id)
            {
                return BadRequest();
            }

            await _contactService.UpdateContact(contact);

            return Ok(contact);
        }

        // POST: api/[controller]
        [HttpPost]
        public async Task<ActionResult<TEntity>> PostContact(Contact contact)
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

            Contact contact = await _contactService.GetContactById(id);

            if (contact == null)
            {
                return NotFound();
            }

            await _contactService.DeleteContact(id);

            return NoContent();
        }

    }
}