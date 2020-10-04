using System.Threading.Tasks;
using Contacts.Api.Models;
using Contacts.Api.Models.Requests;

namespace Contacts.Api.Services
{
    public interface IContactService
    {
        Task<PagedList<Contact>> GetContactsPageAsync(PagedListRequest pagedListRequest);

        Task<Contact> GetContactByIdAsync(int id);

        Task<int> GetContactCountAsync();

        Task<Contact> UpdateContactAsync(Contact contact);

        Task<Contact> CreateContactAsync(Contact contact);

        Task<Contact> DeleteContactAsync(int id);
    }
}