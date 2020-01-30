using System.ComponentModel.DataAnnotations;

namespace OurMemory.Models
{
    public class TextMemoryInputModel
    {
        [Required]
        public string TextContent { get; set; }

        public string UserId { get; set; }
    }
}
