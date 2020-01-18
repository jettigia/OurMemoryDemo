using System.ComponentModel.DataAnnotations;

namespace OurMemory.Models
{
    public class TextMemoryInputModel
    {
        [Required]
        public string Content { get; set; }
    }
}
