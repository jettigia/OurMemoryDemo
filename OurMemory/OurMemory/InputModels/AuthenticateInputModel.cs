using System.ComponentModel.DataAnnotations;

namespace OurMemory.Models
{
    public class AuthenticateInputModel
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}