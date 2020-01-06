using OurMemory.Entities;
using System.Threading.Tasks;

namespace OurMemoryDb
{
    public interface IUserRepository : IRepository<UserEntity>
    {
        Task<UserEntity> ReadEntityAsync(string username);
    }
}
