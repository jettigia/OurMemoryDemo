using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace OurMemory.Entities
{
    public class Memory
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public byte[] Content { get; set; }
        public string ContentType { get; set; }
        public List<Comment> Comments { get; set; }
        public string Title { get; set; }
        public User User { get; set; }
        public Guid UserId { get; set; }
    }
}
