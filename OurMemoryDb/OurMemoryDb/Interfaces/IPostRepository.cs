using OurMemory.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OurMemoryDb
{
    public interface IPostRepository : IRepository<PostEntity>
    {
        Task<List<PostEntity>> ReadAllEntityAsync(Guid userId);
    }
}
