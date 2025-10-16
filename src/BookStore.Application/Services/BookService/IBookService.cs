using BookStore.Application.DataTransferObjects.BookDto;

namespace BookStore.Application.Services.BookService
{
    public interface IBookService
    {
        Task<IEnumerable<BookResponse>> GetAllBooksAsync();
        Task<BookResponse> GetBookByIdAsync(Guid id);
        Task<IEnumerable<BookResponse>> SearchBooksByTitleAsync(string title);
        Task CreateBookAsync(BookRequest request);
        Task UpdateBookAsync(Guid id, BookRequest request);
        Task AddDiscountAsync(Guid id, BookAddDiscountRequest request);
        Task RemoveDiscountAsync(Guid id);
        Task AddStockAsync(Guid id, BookAddStockRequest request);
    }
}
