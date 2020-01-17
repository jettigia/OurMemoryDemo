using Microsoft.EntityFrameworkCore;
using OurMemory.Entities;
using System;
using System.Threading.Tasks;

namespace OurMemoryDb
{
    public class UserRepository : IUserRepository
    {
        private readonly OurMemoryContext _context;

        public UserRepository(OurMemoryContext context)
        {
            _context = context;
        }

        public async Task<UserEntity> CreateEntityAsync(UserEntity entity)
        {
            var isEmailAddressTaken = await _context.UserEntity.AnyAsync(user => user.Email == entity.Email);
            if (isEmailAddressTaken)
                throw new ApplicationException("Email address currently being used.");

            _context.UserEntity.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<UserEntity> ReadEntityAsync(Guid userId)
        {
            var entity = await _context.UserEntity.FindAsync(userId);
            return entity;
        }

        public async Task<UserEntity> ReadEntityAsync(string username)
        {
            var entity = await _context.UserEntity.SingleOrDefaultAsync(x => x.Username == username);
            return entity;
        }

        public async Task<UserEntity> UpdateEntityAsync(UserEntity entity)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteEntityAsync(UserEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
