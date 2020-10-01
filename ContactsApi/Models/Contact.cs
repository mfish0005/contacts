using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ContactsApi.Data;

namespace ContactsApi.Models
{
    public class Contact: IEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }
    }
}
