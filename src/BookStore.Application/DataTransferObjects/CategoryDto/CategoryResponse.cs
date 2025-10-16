using BookStore.Application.DataTransferObjects.BookDto;

namespace BookStore.Application.DataTransferObjects.CategoryDto
{
    public class CategoryResponse
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }

    public class CategoryWithBooksResponse : CategoryResponse
    {
        public IEnumerable<BookResponse> Books { get; set; } = [];
    }

    public class CategoryWithCantBooksResponse: CategoryResponse
    {
        public int Quantity { get; set; }
    }
}
