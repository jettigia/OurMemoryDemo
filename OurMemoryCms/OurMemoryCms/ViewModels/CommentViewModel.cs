using OurMemory.Interfaces;

namespace OurMemoryCms.Models
{
    public class CommentViewModel : IComment
    {
        public string Comment { get; set; }
    }
}