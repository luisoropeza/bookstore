using BookStore.Application.DataTransferObjects.BookDto;

namespace BookStore.Application.DataTransferObjects.AuthorDto
{
    public class AuthorResponse
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }

    public class AuthorWithBooksResponse : AuthorResponse
    {
        public IEnumerable<BookResponse> Books { get; set; } = [];
    }

    public class AuthorWithCantBooksResponse : AuthorResponse
    {
        public int Quantity { get; set; }
    }
}
