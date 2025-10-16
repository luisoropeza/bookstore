using AutoMapper;
using BookStore.Application.DataTransferObjects.AuthorDto;
using BookStore.Domain.Entities;

namespace BookStore.Application.Profiles
{
    public class AuthorProfile : Profile
    {
        public AuthorProfile() {
            CreateMap<AuthorRequest, Author>();
            CreateMap<Author, AuthorResponse>();
            CreateMap<Author, AuthorWithBooksResponse>();
            CreateMap<Author, AuthorWithCantBooksResponse>()
                .ForMember(dest => dest.Quantity, opt => opt.MapFrom(src => src.Books.Count));
        }
    }
}
