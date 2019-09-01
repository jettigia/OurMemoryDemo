using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OurMemoryData.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public virtual IEnumerable<Memory> Memories { get; set; }
    }

    public class ApplicationRole : IdentityRole<Guid>
    {
        public string Description { get; set; }
    }
}
