using OurMemory.Interfaces;
using System;
using System.Collections.Generic;

namespace OurMemory.Models
{
    public class PostViewModel : IPost
    {
        public string Content { get; set; }

        public List<CommentViewModel> Comments { get; set; }
        public Guid Id { get ; set; }
    }
}
