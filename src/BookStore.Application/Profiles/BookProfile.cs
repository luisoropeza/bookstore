using AutoMapper;
using BookStore.Application.DataTransferObjects.BookDto;
using BookStore.Domain.Entities;

namespace BookStore.Application.Profiles
{
    public class BookProfile : Profile
    {
        public BookProfile() {
            CreateMap<Book, BookResponse>();
        }
    }
}
