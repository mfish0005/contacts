using System;

namespace Contacts.Api.Exceptions
{
    public class EntityNotFoundException : Exception
    {
        public EntityNotFoundException(string name, object key)
            : base($"{name} {key} was not found.")
        { }
    }
}