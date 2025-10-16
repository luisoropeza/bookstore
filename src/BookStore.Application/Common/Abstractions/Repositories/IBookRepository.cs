using BookStore.Domain.Entities;

namespace BookStore.Application.Common.Abstractions.Repositories
{
    public interface IBookRepository
    {
        Task<IEnumerable<Book>> GetAllBooksAsync();
        Task<Book?> GetBookByIdAsync(Guid id);
        Task<IEnumerable<Book>> SearchBookByTitleAsync(string title);
        Task CreateBookAsync(Book book);
        Task UpdateBookAsync(Book book);
    }
}
