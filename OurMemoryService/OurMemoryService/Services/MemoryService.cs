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

        public async Task<MemoryViewModel> CreateAsync(string username, MemoryInputModel post)
        {
            var postEntity = _mapper.Map<Memory>(post);
            return await CreateMemoryAsync(username, postEntity);
        }

        public async Task<MemoryViewModel> CreateImageMemoryAsync(string username, MemoryInputModel post)
        {
            var postEntity = _mapper.Map<Memory>(post);
            return await CreateMemoryAsync(username, postEntity);
        }

        private async Task<MemoryViewModel> CreateMemoryAsync(string username, Memory postEntity)
        {
            var user = await _userRepository.ReadEntityAsync(username);
            postEntity.User = user;
            var newEntity = await _postRepository.CreateEntityAsync(postEntity);
            var newViewModel = _mapper.Map<MemoryViewModel>(newEntity);
            return newViewModel;
        }

        public async Task<MemoryViewModel> ReadAsync(Guid postId, string username)
        {
            throw new NotImplementedException();
        }

        public async Task<List<MemoryViewModel>> ReadAsync(string username)
        {
            var postEntities = await _postRepository.ReadAllEntityAsync(username);
            var postModels = _mapper.Map<List<MemoryViewModel>>(postEntities);
            return postModels;
        }

        public async Task<MemoryViewModel> UpdateAsync(MemoryViewModel post)
        {
            var newEntity = _mapper.Map<Memory>(post);
            var updatedEntity = await _postRepository.UpdateEntityAsync(newEntity);
            var updatedModel = _mapper.Map<MemoryViewModel>(updatedEntity);
            return updatedModel;
        }

        public async Task<bool> DeleteAsync(MemoryViewModel post)
        {
            var entityToDelete = _mapper.Map<Memory>(post);
            var isSuccessful = await _postRepository.DeleteEntityAsync(entityToDelete);
            return isSuccessful;
        }
    }
}
