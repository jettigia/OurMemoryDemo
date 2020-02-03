using System;

namespace OurMemory.Entities
{
    public class Comment
    {
        public Guid Id { get; set; }
        public string Content { get; set; }
        public Guid PostId { get; set; }
        public virtual Memory Post { get; set; }
    }
}
