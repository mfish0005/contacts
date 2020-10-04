using Contacts.Api.Models;

namespace Contacts.Api.Data.EfCore.Repositories
{
    public class ContactRepository : EfCoreRepository<Contact, ContactsContext>
    {
        private readonly ContactsContext _context;

        public ContactRepository(ContactsContext context) : base(context)
        {
            _context = context;
        }
    }
}