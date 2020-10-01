using ContactsApi.Data.EfCore.Repositories;
using Microsoft.AspNetCore.Mvc;
using ContactsApi.Models;
using ContactsApi.Services;

namespace ContactsApi.Controllers
{

    [Route("api/contacts")]
    [ApiController]
    public class ContactController : ContactsApiController<Contact, ContactRepository>
    {
        public ContactController(ContactRepository repository, IContactService contactService) : base(repository, contactService)
        {

        }
    }
}