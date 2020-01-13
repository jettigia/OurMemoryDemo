using OurMemory.Configuration;
using System.ComponentModel.DataAnnotations;

namespace OurMemory.Models
{
    public class RegisterViewModel
    {
        [Required, StringLength(255)]
        public string FirstName { get; set; }

        [Required, StringLength(255)]
        public string LastName { get; set; }

        [Required, StringLength(255, MinimumLength = 8)]
        public string Username { get; set; }

        // One uppercase English letter, one lowercase English letter, one digit, one special character, minimum 8 characters in length.
        [Required, RegularExpression(ValidationConstants.PASSWORD_REGEX, ErrorMessage = ValidationConstants.PASSWORD_ERROR_MESSAGE), StringLength(255)]
        public string Password { get; set; }
        
        [Required, EmailAddress, StringLength(320, ErrorMessage = ValidationConstants.EMAIL_LENGTH_ERROR_MESSAGE)]
        public string Email { get; set; }
    }
}