using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactsApi.Models
{
    public class ContactRepository<T> : IContactRepository<T> where T : class
    {
        private readonly ContactsApiContext _context;

        public ContactRepository(ContactsApiContext context)
        {
            _context = context;
        }

        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public async Task<T> SaveAsync(T entity)
        {
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
