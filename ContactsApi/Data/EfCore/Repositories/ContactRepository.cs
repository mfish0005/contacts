using System.Linq;
using System.Threading.Tasks;
using ContactsApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactsApi.Data.EfCore.Repositories
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