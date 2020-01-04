using AutoMapper;
using OurMemory.Entities;
using OurMemory.Interfaces;
using OurMemory.Models;
using OurMemoryDb;
using OurMemoryService.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OurMemoryService.Services
{
    public class PostService : IPostService
    {
        private readonly IPostRepository _postRepository;
        private readonly IMapper _mapper;

        public PostService(IPostRepository postRepository, IMapper mapper)
        {
            _postRepository = postRepository;
            _mapper = mapper;
        }

        public async Task<IPost> Create(IPost post)
        {
            var postEntity = _mapper.Map<PostEntity>(post);
            var newEntity = await _postRepository.CreateEntity(postEntity);
            var newViewModel = _mapper.Map<PostViewModel>(newEntity);
            return newViewModel;
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

        public bool Delete(IPost post)
        {
            throw new NotImplementedException();
        }
    }
}
