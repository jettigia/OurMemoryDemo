using OurMemory.Entities;
using System.Threading.Tasks;

namespace OurMemoryDb
{
    public interface IUserRepository : IRepository<User>
    {
        Task<User> ReadEntityAsync(string username);
    }
}
