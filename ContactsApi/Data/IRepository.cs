using System.Threading.Tasks;
using ContactsApi.Models;

namespace ContactsApi.Data
{
    public interface IRepository<T> where T : class
    {
        Task<T> Get(int id);

        Task<int> GetCount();

        Task<PagedList<T>> GetPagedList(int pageNumber, int pageSize);
        
        Task<T> Add(T entity);

        Task<T> Update(T entity);

        Task<T> Delete(int id);
    }
}