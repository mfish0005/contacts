using System;

namespace Contacts.Api.Exceptions
{
    public class EntityPageNotFoundException : Exception
    {
        public EntityPageNotFoundException(string entity, int pageNumber)
            : base($"{entity} page {pageNumber} not found.")
        { }
    }
}