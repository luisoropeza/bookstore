using BookStore.Application.DataTransferObjects.AuthorDto;
using BookStore.Application.DataTransferObjects.CategoryDto;
using BookStore.Application.DataTransferObjects.ImageDto;

namespace BookStore.Application.DataTransferObjects.BookDto
{
    public class BookResponse
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ISBN { get; set; } = string.Empty;
        public CategoryResponse Category { get; set; } = default!;
        public double Price { get; set; }
        public int Stock { get; set; }
        public double Discount { get; set; }
        public AuthorResponse Author { get; set; } = default!;
        public IEnumerable<ImageResponse> Images { get; set; } = [];
    }
}
