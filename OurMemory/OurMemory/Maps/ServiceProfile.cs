using AutoMapper;
using OurMemory.Entities;
using OurMemory.Models;

namespace OurMemoryService.Maps
{
    public class ServiceProfile : Profile
    {
        public ServiceProfile()
        {
            CreateMap<CommentViewModel, CommentEntity>()
                .ReverseMap();
        }
    }
}
