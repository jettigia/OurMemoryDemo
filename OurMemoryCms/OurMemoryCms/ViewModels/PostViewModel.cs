using OurMemory.Interfaces;
using System.Collections.Generic;

namespace OurMemoryCms.Models
{
    public class PostViewModel : IPost
    {
        public string Content { get; set; }

        public List<CommentViewModel> Comments { get; set; }
        public string Id { get ; set; }
    }
}
