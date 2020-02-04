using System;
using System.Collections.Generic;

namespace OurMemory.Models
{
    public class MemoryViewModel
    {
        public Guid Id { get; set; }
        public string Content { get; set; }

        public List<CommentViewModel> Comments { get; set; }

        public DateTime DateTime { get; set; }

        public string UserIcon { get; set; }

        public string UserId { get; set; }
    }
}
