using OurMemory.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace OurMemory.Entities
{
    public class PostEntity : IPost
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string Content { get; set; }
        public List<CommentEntity> Comments { get; set; }
    }
}
