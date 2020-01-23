using OurMemory.Models;
using System;
using System.Threading.Tasks;

namespace OurMemoryService.Interfaces
{
    public interface IUserService
    {
        Task<UserViewModel> Authenticate(string username, string password);
        Task<UserViewModel> GetById(Guid id);
        Task<UserViewModel> Create(RegisterInputModel user, string password);
        Task<UserViewModel> Update(UpdateViewModel user, string password = null);
    }
}
