using OurMemory.Entities;
using System;
using System.Threading.Tasks;

namespace OurMemoryDb
{
    public class CommentRepository : ICommentRepository
    {
        private readonly OurMemoryContext _context;

        public CommentRepository(OurMemoryContext context)
        {
            _context = context;
        }

        public async Task<Comment> CreateEntityAsync(Comment entity)
        {
            _context.Comments.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<Comment> ReadEntityAsync(Guid id)
        {
            var entity = await _context.Comments.FindAsync(id);
            return entity;
        }

        public async Task<Comment> UpdateEntityAsync(Comment entity)
        {
            var dbEntity = await ReadEntityAsync(entity.Id);
            dbEntity.Content = entity.Content;
            _context.Update(dbEntity);
            await _context.SaveChangesAsync();
            return dbEntity;
        }

        public async Task<bool> DeleteEntityAsync(Comment entity)
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
