using AutoMapper;
using BookStore.Application.Common.Utils;
using BookStore.Application.DataTransferObjects.BookDto;
using BookStore.Application.DataTransferObjects.ImageDto;
using BookStore.Domain.Entities;

namespace BookStore.Application.Profiles
{
    public class BookProfile : Profile
    {
        public BookProfile()
        {
            CreateMap<Book, BookResponse>()
                .ForMember(dest => dest.Price, opt => opt.MapFrom(
                    src => BookUtils.IncludeDiscount(src.Discount, src.Price)
                ));
            CreateMap<BookRequest, Book>();

            //images profile methods
            CreateMap<ImageRequest, Image>();
            CreateMap<Image, ImageResponse>();
        }
    }
}
