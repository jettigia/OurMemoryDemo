using AutoMapper;
using OurMemory.Entities;
using OurMemory.Models;

namespace OurMemoryService.Maps
{
    public class ServiceProfile : Profile
    {
        public ServiceProfile()
        {
            CreateMap<PostViewModel, PostEntity>()
                .ReverseMap();

            CreateMap<CommentViewModel, CommentEntity>()
                .ReverseMap();
        }
    }
}
