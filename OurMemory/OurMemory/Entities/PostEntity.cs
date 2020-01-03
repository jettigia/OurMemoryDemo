using OurMemory.Interfaces;
using System.Collections.Generic;

namespace OurMemory.Entities
{
    public class PostEntity : IPost
    {
        public string Id { get; set; }
        public string Content { get; set; }
        public List<CommentEntity> Comments { get; set; }
    }
}
