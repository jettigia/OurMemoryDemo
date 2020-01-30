using OurMemory.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace OurMemory.Entities
{
    public class UserEntity
    {
        public Guid Id { get; set; }

        [Required, EmailAddress, StringLength(125, ErrorMessage = ValidationConstants.EMAIL_LENGTH_ERROR_MESSAGE)]
        public string Email { get; set; }

        [Required, StringLength(24)]
        public string FirstName { get; set; }

        [Required, StringLength(24)]
        public string LastName { get; set; }

        [Required, StringLength(24, MinimumLength = 8, ErrorMessage = ValidationConstants.USERNAME_ERROR_MESSAGE)]
        public string Username { get; set; }

        [Required]
        public byte[] PasswordHash { get; set; }

        [Required]
        public byte[] PasswordSalt { get; set; }

        public virtual List<MemoryEntity> Memories { get; set; }
    }
}