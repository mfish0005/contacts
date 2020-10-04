using System.ComponentModel.DataAnnotations;

namespace Contacts.Api.Models.Requests
{
    public class PagedListRequest
    {
        [Range(0, 25)]
        public int PageSize { get; set; }

        public int PageNumber { get; set; }
    }
}