using System.ComponentModel.DataAnnotations;

namespace OurMemory.Models
{
    public class MemoryInputModel
    {
        [Required]
        public string TextContent { get; set; }

        public string Title { get; set; }

        public string UserId { get; set; }

        public byte[] FileContent { get; set; }
    }
}
