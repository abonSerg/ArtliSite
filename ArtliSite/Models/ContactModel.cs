using System.ComponentModel.DataAnnotations;

namespace ArtliSite.Models
{
    public class ContactModel
    {
        [Required]
        [StringLength(32, MinimumLength = 2)]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required]
        public string Message { get; set; }


        public override string ToString()
        {
            return $"Name: \"{Name}\"\n\rEmail: \"{Email}\"\n\rSubject: \"{Subject}\"\n\rMessage: \"{Message}\"\n\r";
        }
    }
}