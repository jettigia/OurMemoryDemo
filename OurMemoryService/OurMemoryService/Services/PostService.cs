using OurMemory.Interfaces;
using OurMemoryService.Interfaces;
using System;
using System.Collections.Generic;

namespace OurMemoryService.Services
{
    public class PostService : IPostService
    {
        public IPost Create(IPost post)
        {
            throw new NotImplementedException();
        }

        public bool Delete(IPost post)
        {
            throw new NotImplementedException();
        }

        public IPost Read(string postId, string userId)
        {
            throw new NotImplementedException();
        }

        public List<IPost> Read(string userId)
        {
            throw new NotImplementedException();
        }

        public IPost Update(IPost post)
        {
            throw new NotImplementedException();
        }
    }
}
