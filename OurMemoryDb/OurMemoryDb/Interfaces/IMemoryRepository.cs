using OurMemory.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OurMemoryDb
{
    public interface IMemoryRepository : IRepository<MemoryEntity>
    {
        Task<List<MemoryEntity>> ReadAllEntityAsync(Guid userId);
    }
}
