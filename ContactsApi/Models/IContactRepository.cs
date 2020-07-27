using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactsApi.Models
{
    public interface IContactRepository<T> where T : class
    {
        PagedList<Contact> GetContacts(ContactParameters ownerParameters);
        
        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);

        Task<T> SaveAsync(T entity);
    }
}
