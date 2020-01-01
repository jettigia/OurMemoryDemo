using OurMemory.Interfaces;
using System.Collections.Generic;

namespace OurMemoryService.Interfaces
{
    public interface IPostService
    {
        IPost Create(IPost post);

        IPost Read(string postId, string userId);

        List<IPost> Read(string userId);

        IPost Update(IPost post);

        bool Delete(IPost post);
    }
}
