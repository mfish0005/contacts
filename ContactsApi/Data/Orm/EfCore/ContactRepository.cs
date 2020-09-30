using System.Linq;
using System.Threading.Tasks;
using ContactsApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactsApi.Data.Orm.EfCore
{
    public class ContactRepository : EfCoreRepository<Contact, ContactsContext>
    {
        private readonly ContactsContext _context;
        
        public ContactRepository(ContactsContext context) : base(context)
        {
            this._context = context;
        }   
        
        // TODO: Add paged endpoint here

        // public async Task<int> GetContactsCount()
        // {
        //     return await _context.Contacts.CountAsync();
        // }
    }
}