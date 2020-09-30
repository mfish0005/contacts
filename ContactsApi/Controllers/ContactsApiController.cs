using System.Collections.Generic;
using System.Threading.Tasks;
using ContactsApi.Data;
using ContactsApi.Models;
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

        protected ContactsApiController(TRepository repository)
        {
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

            var result = _repository.GetPagedList(contactParameters);

            return Ok(result);
        }

        // GET: api/[controller]/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TEntity>> Get(int id)
        {
            var entity = await _repository.Get(id);

            if (entity == null)
            {
                return NotFound();
            }

            return entity;
        }

        // GET: api/[controller]/count
        [HttpGet]
        [Route("count")]
        public async Task<ActionResult<int>> GetEntityCount()
        {
            var count = await _repository.GetCount();

            return count;
        }

        // PUT: api/[controller]/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, TEntity entity)
        {
            if (id != entity.Id)
            {
                return BadRequest();
            }

            await _repository.Update(entity);

            return NoContent();
        }

        // POST: api/[controller]
        [HttpPost]
        public async Task<ActionResult<TEntity>> Post(TEntity entity)
        {
            await _repository.Add(entity);

            return CreatedAtAction("Get", new { id = entity.Id }, entity);
        }

        // DELETE: api/[controller]/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TEntity>> Delete(int id)
        {
            var entity = await _repository.Delete(id);

            if (entity == null)
            {
                return NotFound();
            }

            return entity;
        }

    }
}