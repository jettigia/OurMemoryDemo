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
            CreateMap<RegisterInputModel, UserEntity>().ReverseMap();
            CreateMap<RegisterInputModel, UserViewModel>().ReverseMap();
            CreateMap<UserViewModel, UserEntity>().ReverseMap();
            CreateMap<UpdateViewModel, UserEntity>().ReverseMap();
        }
    }
}