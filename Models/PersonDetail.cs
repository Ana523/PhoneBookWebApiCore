using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneBookWebApi.Models
{
    public class PersonDetail
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(150)")]
        public string FirstName { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(150)")]
        public string LastName { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(150)")]
        public string Country { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(150)")]
        public string City { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(150)")]
        public string Address { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(150)")]
        public string PhoneNumber { get; set; }
    }
}
