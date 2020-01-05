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

        public async Task<CommentEntity> CreateEntityAsync(CommentEntity entity)
        {
            _context.CommentEntities.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<CommentEntity> ReadEntityAsync(Guid id)
        {
            var entity = await _context.CommentEntities.FindAsync(id);
            return entity;
        }

        public async Task<CommentEntity> UpdateEntityAsync(CommentEntity entity)
        {
            var dbEntity = await ReadEntityAsync(entity.Id);
            dbEntity.Comment = entity.Comment;
            _context.Update(dbEntity);
            await _context.SaveChangesAsync();
            return dbEntity;
        }

        public async Task<bool> DeleteEntityAsync(CommentEntity entity)
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
