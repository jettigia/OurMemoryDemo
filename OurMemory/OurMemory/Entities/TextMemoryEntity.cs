using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace OurMemory.Entities
{
    public class TextMemoryEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string Content { get; set; }
        public List<CommentEntity> Comments { get; set; }
        public UserEntity User { get; set; }
        public string UserId { get; set; }
    }
}
