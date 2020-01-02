using OurMemory.Interfaces;

namespace OurMemoryDb.Entities
{
    public class CommentEntity : IComment
    {
        public string Id { get; set; }
        public string Comment { get; set; }
        public virtual PostEntity Post { get; set; }
    }
}
