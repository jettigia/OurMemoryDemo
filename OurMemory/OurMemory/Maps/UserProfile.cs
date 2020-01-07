using AutoMapper;
using OurMemory.Entities;
using OurMemory.Models;

namespace OurMemoryService.Maps
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserEntity, UserViewModel>().ReverseMap();
            CreateMap<RegisterViewModel, UserEntity>().ReverseMap();
            CreateMap<RegisterViewModel, UserViewModel>().ReverseMap();
            CreateMap<UserViewModel, UserEntity>().ReverseMap();
            CreateMap<UpdateViewModel, UserEntity>().ReverseMap();
        }
    }
}