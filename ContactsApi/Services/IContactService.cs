using System.Threading.Tasks;
using ContactsApi.Data;
using ContactsApi.Models;
using ContactsApi.Models.Requests;
using Microsoft.AspNetCore.Mvc;

namespace ContactsApi.Services
{
    public interface IContactService
    {
        Task<PagedList<Contact>> GetContactsPage(PagedListRequest pagedListRequest);
        Task<Contact> GetContactById(int id);
        Task<int> GetContactCount();
        Task<Contact> UpdateContact(Contact contact);
        Task<Contact> CreateContact(Contact contact);
        Task DeleteContact(int id);
    }
}