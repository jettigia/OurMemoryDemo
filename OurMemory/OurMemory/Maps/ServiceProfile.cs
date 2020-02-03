using AutoMapper;
using OurMemory.Entities;
using OurMemory.Models;

namespace OurMemoryService.Maps
{
    public class ServiceProfile : Profile
    {
        public ServiceProfile()
        {
            CreateMap<ImageMemoryInputModel, Memory>()
                .ForMember(destination => destination.Content, opts => opts.MapFrom(source => source.FileContent));

            CreateMap<TextMemoryInputModel, Memory>()
                .ForMember(destination => destination.Title, opts => opts.MapFrom(source => source.TextContent));           

            CreateMap<Memory, TextMemoryViewModel>();

            CreateMap<CommentViewModel, Comment>()
                .ReverseMap();
        }
    }
}
