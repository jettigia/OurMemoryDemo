using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OurMemory.Data.Entities
{
    public class Memory : IMemory
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }
        

        [ForeignKey("ApplicationUserId")]
        public ApplicationUser ApplicationUser { get; set; }

        public int ApplicationUserId { get; set; }
    }
}
