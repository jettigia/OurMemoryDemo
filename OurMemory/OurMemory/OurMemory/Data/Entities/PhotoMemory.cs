using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OurMemory.Data.Entities
{
    public class PhotoMemory : Memory
    {
        public byte[] Image { get; set; }
    }
}
