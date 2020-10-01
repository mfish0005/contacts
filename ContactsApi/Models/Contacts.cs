using System.Collections;
using System.Collections.Generic;

namespace ContactsApi.Models
{
    public class Contacts
    {
        public IEnumerable<Contact> ContactsList { get; set; }
    }
}