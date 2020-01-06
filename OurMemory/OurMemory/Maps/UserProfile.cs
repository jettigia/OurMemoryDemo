using AutoMapper;
using OurMemory.Entities;
using OurMemory.Models;

namespace OurMemoryService.Maps
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserEntity, UserViewModel>();
            CreateMap<RegisterViewModel, UserEntity>();
            CreateMap<UpdateViewModel, UserEntity>();
        }
    }
}