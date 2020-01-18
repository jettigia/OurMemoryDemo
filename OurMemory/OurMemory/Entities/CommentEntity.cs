using System;

namespace OurMemory.Entities
{
    public class CommentEntity
    {
        public Guid Id { get; set; }
        public string Comment { get; set; }
        public Guid PostId { get; set; }
        public virtual TextMemoryEntity Post { get; set; }
    }
}
