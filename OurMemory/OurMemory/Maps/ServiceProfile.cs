using AutoMapper;
using OurMemory.Entities;
using OurMemory.Models;

namespace OurMemoryService.Maps
{
    public class ServiceProfile : Profile
    {
        public ServiceProfile()
        {
            CreateMap<TextMemoryInputModel, TextMemoryEntity>();

            CreateMap<TextMemoryEntity, TextMemoryViewModel>();

            CreateMap<CommentViewModel, CommentEntity>()
                .ReverseMap();
        }
    }
}
