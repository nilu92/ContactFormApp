using System.ComponentModel.DataAnnotations;

namespace ContactFormApp.Models
{

    public class Contact
    {
        public int Id { get; set; }  

        [Required]
        [StringLength(100)]
        public string? FirstName { get; set; }

        [Required]
        [StringLength(100)]
        public string? LastName { get; set; }

        [Required]
        [EmailAddress]
        public string? Email { get; set; }

        [Phone]
        public string ?PhoneNumber { get; set; }
    }
}
