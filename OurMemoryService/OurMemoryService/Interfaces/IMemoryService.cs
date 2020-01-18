using OurMemory.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OurMemoryService.Interfaces
{
    public interface IMemoryService
    {
        Task<TextMemoryViewModel> CreateTextMemoryAsync(string userId, TextMemoryInputModel post);

        Task<TextMemoryViewModel> ReadAsync(Guid postId, Guid userId);

        Task<List<TextMemoryViewModel>> ReadAsync(Guid userId);

        Task<TextMemoryViewModel> UpdateAsync(TextMemoryViewModel post);

        Task<bool> DeleteAsync(TextMemoryViewModel post);
    }
}
