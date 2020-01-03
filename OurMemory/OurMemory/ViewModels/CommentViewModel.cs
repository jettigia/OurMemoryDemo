using OurMemory.Interfaces;

namespace OurMemory.Models
{
    public class CommentViewModel : IComment
    {
        public string Comment { get; set; }
    }
}