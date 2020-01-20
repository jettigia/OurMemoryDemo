using System.ComponentModel.DataAnnotations;

namespace OurMemory.Models
{
    public class AuthenticateInputModel
    {
        [Required, StringLength(255, MinimumLength = 8)]
        public string Username { get; set; }

        [Required, StringLength(255)]
        public string Password { get; set; }
    }
}