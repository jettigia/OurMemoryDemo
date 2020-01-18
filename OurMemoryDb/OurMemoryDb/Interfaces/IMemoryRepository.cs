using OurMemory.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OurMemoryDb
{
    public interface IMemoryRepository : IRepository<TextMemoryEntity>
    {
        Task<List<TextMemoryEntity>> ReadAllEntityAsync(Guid userId);
    }
}
