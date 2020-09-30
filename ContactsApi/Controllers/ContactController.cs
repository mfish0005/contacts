using ContactsApi.Data.Orm.EfCore;
using Microsoft.AspNetCore.Mvc;
using ContactsApi.Models;

namespace ContactsApi.Controllers
{

    [Route("api/contacts")]
    [ApiController]
    public class ContactController : ContactsApiController<Contact, ContactRepository>
    {
        public ContactController(ContactRepository repository) : base(repository)
        {
            
        }
    }
}