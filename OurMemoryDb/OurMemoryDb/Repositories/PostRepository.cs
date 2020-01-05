using Microsoft.EntityFrameworkCore;
using OurMemory.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OurMemoryDb
{
    public class PostRepository : IPostRepository
    {
        private readonly OurMemoryContext _context;

        public PostRepository(OurMemoryContext context)
        {
            _context = context;
        }

        public async Task<PostEntity> CreateEntityAsync(PostEntity entity)
        {
            await _context.PostEntities.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<PostEntity> ReadEntityAsync(Guid postId)
        {
            var entity = await _context.PostEntities.FindAsync(postId);
            return entity;
        }

        public async Task<List<PostEntity>> ReadAllEntityAsync(Guid userId)
        {
            var connection = _context.Database.GetDbConnection();
            _context.SaveChanges();
            var entity = await _context.PostEntities.ToListAsync();
            return entity;
        }

        public async Task<PostEntity> UpdateEntityAsync(PostEntity entity)
        {
            var dbEntity = await ReadEntityAsync(entity.Id);
            dbEntity.Content = entity.Content;
            _context.Update(dbEntity);
            await _context.SaveChangesAsync();
            return dbEntity;
        }

        public async Task<bool> DeleteEntityAsync(PostEntity entity)
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
