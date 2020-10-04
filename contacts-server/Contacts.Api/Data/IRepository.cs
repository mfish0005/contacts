using System.Threading.Tasks;
using Contacts.Api.Models;

namespace Contacts.Api.Data
{
    public interface IRepository<T> where T : class
    {
        Task<T> Get(int id);

        Task<int> GetCount();

        Task<PagedList<T>> GetPagedList(int pageNumber, int pageSize);

        Task<T> Add(T entity);

        Task<T> Update(T entity);

        Task<T> Remove(T entity);
    }
}