using OurMemory.Entities;
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

        public async Task<CommentEntity> CreateEntity(CommentEntity entity)
        {
            _context.Comments.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<CommentEntity> ReadEntity(string id)
        {
            var entity = await _context.Comments.FindAsync(id);
            return entity;
        }

        public async Task<CommentEntity> UpdateEntity(CommentEntity entity)
        {
            var dbEntity = await ReadEntity(entity.Id);
            dbEntity.Comment = entity.Comment;
            _context.Update(dbEntity);
            await _context.SaveChangesAsync();
            return dbEntity;
        }

        public async Task<bool> DeleteEntity(CommentEntity entity)
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
