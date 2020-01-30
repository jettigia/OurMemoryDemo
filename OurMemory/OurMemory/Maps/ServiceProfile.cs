using AutoMapper;
using OurMemory.Entities;
using OurMemory.Models;

namespace OurMemoryService.Maps
{
    public class ServiceProfile : Profile
    {
        public ServiceProfile()
        {
            CreateMap<ImageMemoryInputModel, MemoryEntity>()
                .ForMember(destination => destination.Content, opts => opts.MapFrom(source => source.FileContent));

            CreateMap<TextMemoryInputModel, MemoryEntity>()
                .ForMember(destination => destination.Title, opts => opts.MapFrom(source => source.TextContent));           

            CreateMap<MemoryEntity, TextMemoryViewModel>();

            CreateMap<CommentViewModel, CommentEntity>()
                .ReverseMap();
        }
    }
}
