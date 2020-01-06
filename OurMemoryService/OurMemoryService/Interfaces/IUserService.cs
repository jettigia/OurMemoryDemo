using OurMemory.Models;
using System;
using System.Threading.Tasks;

namespace OurMemoryService.Interfaces
{
    public interface IUserService
    {
        Task<UserViewModel> Authenticate(string username, string password);
        Task<UserViewModel> GetById(Guid id);
        Task<UserViewModel> Create(UserViewModel user, string password);
        Task<UserViewModel> Update(UserViewModel user, string password = null);
    }
}
