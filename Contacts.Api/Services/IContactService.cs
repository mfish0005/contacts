using System.Threading.Tasks;
using Contacts.Api.Data;
using Contacts.Api.Models;
using Contacts.Api.Models.Requests;
using Microsoft.AspNetCore.Mvc;

namespace Contacts.Api.Services
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