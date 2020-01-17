using OurMemory.Interfaces;
using System;

namespace OurMemory.Models
{
    public class CommentViewModel : IComment
    {
        public string Comment { get; set; }

        public DateTime DateTime { get; set; }
    }
}