using System.ComponentModel.DataAnnotations;

namespace OurMemory.Models
{
    public class AuthenticateViewModel
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}