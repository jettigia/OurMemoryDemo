using OurMemory.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OurMemoryService.Interfaces
{
    public interface IMemoryService
    {
        Task<MemoryViewModel> CreateAsync(string userId, MemoryInputModel post);

        Task<MemoryViewModel> ReadAsync(Guid postId, Guid userId);

        Task<List<MemoryViewModel>> ReadAsync(Guid userId);

        Task<MemoryViewModel> UpdateAsync(MemoryViewModel post);

        Task<bool> DeleteAsync(MemoryViewModel post);
    }
}
