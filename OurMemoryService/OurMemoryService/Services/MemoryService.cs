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
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public MemoryService(IMemoryRepository postRepository, IUserRepository userRepository, IMapper mapper)
        {
            _postRepository = postRepository;
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<TextMemoryViewModel> CreateTextMemoryAsync(string username, TextMemoryInputModel post)
        {
            var postEntity = _mapper.Map<MemoryEntity>(post);
            return await CreateMemoryAsync(username, postEntity);
        }

        public async Task<TextMemoryViewModel> CreateImageMemoryAsync(string username, ImageMemoryInputModel post)
        {
            var postEntity = _mapper.Map<MemoryEntity>(post);
            return await CreateMemoryAsync(username, postEntity);
        }

        private async Task<TextMemoryViewModel> CreateMemoryAsync(string username, MemoryEntity postEntity)
        {
            var user = await _userRepository.ReadEntityAsync(username);
            postEntity.User = user;
            var newEntity = await _postRepository.CreateEntityAsync(postEntity);
            var newViewModel = _mapper.Map<ImageMemoryViewModel>(newEntity);
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
            var newEntity = _mapper.Map<MemoryEntity>(post);
            var updatedEntity = await _postRepository.UpdateEntityAsync(newEntity);
            var updatedModel = _mapper.Map<TextMemoryViewModel>(updatedEntity);
            return updatedModel;
        }

        public async Task<bool> DeleteAsync(TextMemoryViewModel post)
        {
            var entityToDelete = _mapper.Map<MemoryEntity>(post);
            var isSuccessful = await _postRepository.DeleteEntityAsync(entityToDelete);
            return isSuccessful;
        }
    }
}
