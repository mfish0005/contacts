using System.Threading.Tasks;
using Contacts.Api.Data;
using Contacts.Api.Data.EfCore.Repositories;
using Contacts.Api.Models;
using Contacts.Api.Models.Requests;

namespace Contacts.Api.Services
{
    public class ContactService: IContactService
    {
        private readonly ContactRepository _contactRepository;

        public ContactService(ContactRepository repository)
        {
            _contactRepository = repository;
        }

        public async Task<PagedList<Contact>> GetContactsPage(PagedListRequest request)
        {
            var contacts = await _contactRepository.GetPagedList(request.PageNumber, request.PageSize);

            return contacts;
        }

        public async Task<Contact> GetContactById(int id)
        {
            var contact = await _contactRepository.Get(id);

            return contact;
        }

        public async Task<int> GetContactCount()
        {
            var count = await _contactRepository.GetCount();

            return count;
        }

        public async Task<Contact> CreateContact(Contact contact)
        {
            await _contactRepository.Add(contact);

            return contact;
        }

        public async Task<Contact> UpdateContact(Contact contact)
        {
            await _contactRepository.Update(contact);

            return contact;
        }

        public async Task DeleteContact(int id)
        {
            await _contactRepository.Remove(id);
        }
    }
}