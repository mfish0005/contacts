using System;

namespace Contacts.Api.Exceptions
{
    public class EntityNotFoundException : Exception
    {
        public EntityNotFoundException(string entityName, object key)
            : base($"{entityName} {key} was not found.")
        { }
    }
}