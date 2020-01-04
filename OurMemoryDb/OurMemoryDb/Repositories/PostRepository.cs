using OurMemory.Entities;
using System;
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

        public async Task<PostEntity> CreateEntity(PostEntity entity)
        {
            await _context.Posts.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<PostEntity> ReadEntity(Guid id)
        {
            var entity = await _context.Posts.FindAsync(id);
            return entity;
        }

        public async Task<PostEntity> UpdateEntity(PostEntity entity)
        {
            var dbEntity = await ReadEntity(entity.Id);
            dbEntity.Content = entity.Content;
            _context.Update(dbEntity);
            await _context.SaveChangesAsync();
            return dbEntity;
        }

        public async Task<bool> DeleteEntity(PostEntity entity)
        {
            try
            {
                var dbEntity = await ReadEntity(entity.Id);
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
