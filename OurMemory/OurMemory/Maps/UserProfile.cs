using AutoMapper;
using OurMemory.Entities;
using OurMemory.Models;

namespace OurMemoryService.Maps
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserViewModel>().ReverseMap();
            CreateMap<RegisterInputModel, User>().ReverseMap();
            CreateMap<RegisterInputModel, UserViewModel>().ReverseMap();
            CreateMap<UserViewModel, User>().ReverseMap();
            CreateMap<UpdateViewModel, User>().ReverseMap();
        }
    }
}