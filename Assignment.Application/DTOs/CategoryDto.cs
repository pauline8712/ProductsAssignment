using AutoMapper;
using Assignment.Application.DTOs;
using Assignment.Domain.Entities;

namespace Assignment.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductDto>()
                .ForMember(dest => dest.CategoryName,
                    opt => opt.MapFrom(src => src.Category.Name));

            CreateMap<Category, CategoryDto>();
        }
    }
}