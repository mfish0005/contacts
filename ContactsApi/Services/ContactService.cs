using System.Threading.Tasks;
using ContactsApi.Data;
using ContactsApi.Data.EfCore.Repositories;
using ContactsApi.Models;

namespace ContactsApi.Services
{
    public class ContactService: IContactService
    {
        private readonly ContactRepository _contactRepository;

        public ContactService(ContactRepository repository)
        {
            _contactRepository = repository;
        }

        public async Task<PagedList<Contact>> GetContactsPage(int pageNumber, int pageSize)
        {
            PagedList<Contact> contactsPage = await _contactRepository.GetPagedList(pageNumber, pageSize);

            return contactsPage;
        }

        public async Task<Contact> GetContactById(int id)
        {
            Contact contact = await _contactRepository.Get(id);

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