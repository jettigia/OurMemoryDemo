using OurMemory.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OurMemoryDb
{
    public interface IMemoryRepository : IRepository<Memory>
    {
        Task<List<Memory>> ReadAllEntityAsync(string username);
    }
}
