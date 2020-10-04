using System;
using Contacts.Api.Models.Requests;

namespace Contacts.Api.Exceptions
{
    public class PageNotFoundException : Exception
    {
        public PageNotFoundException(string entityName, int pageNumber)
            : base($"{entityName} page {pageNumber} was not found.")
        { }
    }
}