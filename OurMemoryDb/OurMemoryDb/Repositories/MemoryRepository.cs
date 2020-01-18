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

        public async Task<TextMemoryEntity> CreateEntityAsync(TextMemoryEntity entity)
        {
            await _context.PostEntities.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<TextMemoryEntity> ReadEntityAsync(Guid postId)
        {
            var entity = await _context.PostEntities.FindAsync(postId);
            return entity;
        }

        public async Task<List<TextMemoryEntity>> ReadAllEntityAsync(Guid userId)
        {
            var connection = _context.Database.GetDbConnection();
            _context.SaveChanges();
            var entity = await _context.PostEntities.ToListAsync();
            return entity;
        }

        public async Task<TextMemoryEntity> UpdateEntityAsync(TextMemoryEntity entity)
        {
            var dbEntity = await ReadEntityAsync(entity.Id);
            dbEntity.Content = entity.Content;
            _context.Update(dbEntity);
            await _context.SaveChangesAsync();
            return dbEntity;
        }

        public async Task<bool> DeleteEntityAsync(TextMemoryEntity entity)
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
