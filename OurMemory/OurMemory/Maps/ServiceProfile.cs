using AutoMapper;
using OurMemory.Entities;
using OurMemory.Models;

namespace OurMemoryService.Maps
{
    public class ServiceProfile : Profile
    {
        public ServiceProfile()
        {
            CreateMap<MemoryInputModel, Memory>()
                .ForMember(destination => destination.Content, opts => opts.MapFrom(source => source.FileContent));

            CreateMap<MemoryInputModel, Memory>()
                .ForMember(destination => destination.Title, opts => opts.MapFrom(source => source.TextContent));           

            CreateMap<Memory, MemoryViewModel>()
                .ReverseMap();

            CreateMap<CommentViewModel, Comment>()
                .ReverseMap();
        }
    }
}
