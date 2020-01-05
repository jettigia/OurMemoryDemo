using OurMemory.Interfaces;
using OurMemory.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OurMemoryService.Interfaces
{
    public interface IPostService
    {
        Task<PostViewModel> CreateAsync(PostViewModel post);

        Task<PostViewModel> ReadAsync(Guid postId, Guid userId);

        Task<List<PostViewModel>> ReadAsync(Guid userId);

        Task<PostViewModel> UpdateAsync(PostViewModel post);

        Task<bool> DeleteAsync(PostViewModel post);
    }
}
