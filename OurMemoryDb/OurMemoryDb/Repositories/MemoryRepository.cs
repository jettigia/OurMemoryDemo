using Microsoft.EntityFrameworkCore;
using OurMemory.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OurMemoryDb
{
    public class MemoryRepository : IMemoryRepository
    {
        private readonly OurMemoryContext _context;

        public MemoryRepository(OurMemoryContext context)
        {
            _context = context;
        }

        public async Task<MemoryEntity> CreateEntityAsync(MemoryEntity entity)
        {
            await _context.Memories.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<MemoryEntity> ReadEntityAsync(Guid postId)
        {
            var entity = await _context.Memories.FindAsync(postId);
            return entity;
        }

        public async Task<List<MemoryEntity>> ReadAllEntityAsync(Guid userId)
        {
            var connection = _context.Database.GetDbConnection();
            _context.SaveChanges();
            var entity = await _context.Memories.ToListAsync();
            return entity;
        }

        public async Task<MemoryEntity> UpdateEntityAsync(MemoryEntity entity)
        {
            var dbEntity = await ReadEntityAsync(entity.Id);
            dbEntity.Content = entity.Content;
            _context.Update(dbEntity);
            await _context.SaveChangesAsync();
            return dbEntity;
        }

        public async Task<bool> DeleteEntityAsync(MemoryEntity entity)
        {
            try
            {
                var dbEntity = await ReadEntityAsync(entity.Id);
                _context.Remove(dbEntity);
                await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
