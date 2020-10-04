using System.Threading.Tasks;
using Contacts.Api.Data.EfCore.Repositories;
using Contacts.Api.Exceptions;
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

        public async Task<PagedList<Contact>> GetContactsPageAsync(PagedListRequest request)
        {
            var contacts = await _contactRepository.GetPagedList(request.PageNumber, request.PageSize);

            if (contacts == null || contacts.Count <= 0) {
                throw new EntityPageNotFoundException(nameof(Contact), request.PageNumber);
            }

            return contacts;
        }

        public async Task<Contact> GetContactByIdAsync(int id)
        {
            var contact = await _contactRepository.Get(id);

            if (contact == null)
            {
                throw new EntityNotFoundException(nameof(Contact), id);
            }

            return contact;
        }

        public async Task<int> GetContactCountAsync()
        {
            var count = await _contactRepository.GetCount();

            return count;
        }

        public async Task<Contact> CreateContactAsync(Contact contact)
        {
            await _contactRepository.Add(contact);

            return contact;
        }

        public async Task<Contact> UpdateContactAsync(Contact contact)
        {
            var updatedContact = await _contactRepository.Update(contact);

            if (updatedContact == null) {
                throw new EntityNotFoundException(nameof(Contact), contact.Id);
            }

            return updatedContact;
        }

        public async Task<Contact> DeleteContactAsync(int id)
        {
            var contact = GetContactByIdAsync(id);
            
            return await _contactRepository.Remove(await contact);
        }
    }
}