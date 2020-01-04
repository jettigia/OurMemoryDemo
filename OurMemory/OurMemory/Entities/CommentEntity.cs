using OurMemory.Interfaces;
using System;

namespace OurMemory.Entities
{
    public class CommentEntity : IComment
    {
        public Guid Id { get; set; }
        public string Comment { get; set; }
        public virtual PostEntity Post { get; set; }
    }
}
