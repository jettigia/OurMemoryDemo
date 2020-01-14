using OurMemory.Configuration;
using System;
using System.ComponentModel.DataAnnotations;

namespace OurMemory.Entities
{
    public class UserEntity
    {
        public Guid Id { get; set; }

        [Required, StringLength(320)]
        public string Email { get; set; }

        [Required, StringLength(255)]
        public string FirstName { get; set; }

        [Required, StringLength(255)]
        public string LastName { get; set; }

        [Required, StringLength(255, MinimumLength = 8)]
        public string Username { get; set; }

        [Required]
        public byte[] PasswordHash { get; set; }

        [Required]
        public byte[] PasswordSalt { get; set; }
    }
}