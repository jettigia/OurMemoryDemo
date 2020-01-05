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

        public async Task<PostViewModel> CreateAsync(PostViewModel post)
        {
            var postEntity = _mapper.Map<PostEntity>(post);
            var newEntity = await _postRepository.CreateEntityAsync(postEntity);
            var newViewModel = _mapper.Map<PostViewModel>(newEntity);
            return newViewModel;
        }

        public async Task<PostViewModel> ReadAsync(Guid postId, Guid userId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<PostViewModel>> ReadAsync(Guid userId)
        {
            var postEntities = await _postRepository.ReadAllEntityAsync(userId);
            var postModels = _mapper.Map<List<PostViewModel>>(postEntities);
            return postModels;            
        }

        public async Task<PostViewModel> UpdateAsync(PostViewModel post)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(PostViewModel post)
        {
            throw new NotImplementedException();
        }
    }
}
