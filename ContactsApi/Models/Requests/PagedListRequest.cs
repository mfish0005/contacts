using System.ComponentModel.DataAnnotations;

namespace ContactsApi.Models.Requests
{
    public class PagedListRequest
    {
        [Range(0, 25)]
        public int PageSize { get; set; }

        public int PageNumber { get; set; }
    }
}