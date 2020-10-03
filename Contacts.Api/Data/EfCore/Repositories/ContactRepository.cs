using System.Linq;
using System.Threading.Tasks;
using Contacts.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Contacts.Api.Data.EfCore.Repositories
{
    public class ContactRepository : EfCoreRepository<Contact, ContactsContext>
    {
        private readonly ContactsContext _context;

        public ContactRepository(ContactsContext context) : base(context)
        {
            this._context = context;
        }
    }
}