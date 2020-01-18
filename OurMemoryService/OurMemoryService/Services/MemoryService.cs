using AutoMapper;
using OurMemory.Entities;
using OurMemory.Models;
using OurMemoryDb;
using OurMemoryService.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OurMemoryService.Services
{
    public class MemoryService : IMemoryService
    {
        private readonly IMemoryRepository _postRepository;
        private readonly IMapper _mapper;

        public MemoryService(IMemoryRepository postRepository, IMapper mapper)
        {
            _postRepository = postRepository;
            _mapper = mapper;
        }

        public async Task<TextMemoryViewModel> CreateTextMemoryAsync(string userId, TextMemoryInputModel post)
        {
            var postEntity = _mapper.Map<TextMemoryEntity>(post);
            postEntity.UserId = userId;
            var newEntity = await _postRepository.CreateEntityAsync(postEntity);
            var newViewModel = _mapper.Map<TextMemoryViewModel>(newEntity);
            return newViewModel;
        }

        public async Task<TextMemoryViewModel> ReadAsync(Guid postId, Guid userId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<TextMemoryViewModel>> ReadAsync(Guid userId)
        {
            var postEntities = await _postRepository.ReadAllEntityAsync(userId);
            var postModels = _mapper.Map<List<TextMemoryViewModel>>(postEntities);
            return postModels;
        }

        public async Task<TextMemoryViewModel> UpdateAsync(TextMemoryViewModel post)
        {
            var newEntity = _mapper.Map<TextMemoryEntity>(post);
            var updatedEntity = await _postRepository.UpdateEntityAsync(newEntity);
            var updatedModel = _mapper.Map<TextMemoryViewModel>(updatedEntity);
            return updatedModel;
        }

        public async Task<bool> DeleteAsync(TextMemoryViewModel post)
        {
            var entityToDelete = _mapper.Map<TextMemoryEntity>(post);
            var isSuccessful = await _postRepository.DeleteEntityAsync(entityToDelete);
            return isSuccessful;
        }
    }
}
