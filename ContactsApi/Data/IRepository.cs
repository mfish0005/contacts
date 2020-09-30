using System.Threading.Tasks;
using ContactsApi.Models;

namespace ContactsApi.Data
{
    public interface IRepository<T> where T : class
    {
        Task<T> Get(int id);

        Task<int> GetCount();

        PagedList<T> GetPagedList(ContactParameters contactParameters);
        
        Task<T> Add(T entity);

        Task<T> Update(T entity);

        Task<T> Delete(int id);
    }
}