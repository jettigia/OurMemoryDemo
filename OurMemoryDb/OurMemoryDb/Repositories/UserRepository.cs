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

        public async Task<User> CreateEntityAsync(User entity)
        {
            var isEmailAddressTaken = await _context.Users.AnyAsync(user => user.Email == entity.Email);
            if (isEmailAddressTaken)
                throw new ApplicationException("Email address currently being used.");

            _context.Users.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<User> ReadEntityAsync(Guid userId)
        {
            var entity = await _context.Users.FindAsync(userId);
            return entity;
        }

        public async Task<User> ReadEntityAsync(string username)
        {
            var entity = await _context.Users.SingleOrDefaultAsync(x => x.Username == username);
            return entity;
        }

        public async Task<User> UpdateEntityAsync(User entity)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteEntityAsync(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
