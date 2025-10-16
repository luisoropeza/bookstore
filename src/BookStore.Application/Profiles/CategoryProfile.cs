using AutoMapper;
using BookStore.Application.DataTransferObjects.CategoryDto;
using BookStore.Domain.Entities;

namespace BookStore.Application.Profiles
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile() {
            CreateMap<Category, CategoryResponse>();
            CreateMap<Category, CategoryWithBooksResponse>();
            CreateMap<Category, CategoryWithCantBooksResponse>()
                .ForMember(dest => dest.Quantity, opt => opt.MapFrom(src => src.Books.Count));
        }
    }
}
