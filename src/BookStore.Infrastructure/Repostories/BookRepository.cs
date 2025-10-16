using BookStore.Application.Common.Abstractions.Repositories;
using BookStore.Domain.Entities;
using BookStore.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Infrastructure.Repostories
{
    public class BookRepository(BookStoreDbContext context) : IBookRepository
    {
        public async Task CreateBookAsync(Book book)
        {
            context.Books.Add(book);
            await context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Book>> GetAllBooksAsync()
        {
            return await context.Books
                .Include(b => b.Author)
                .Include(b => b.Category)
                .Include(b => b.Images)
                .ToListAsync();
        }

        public async Task<Book?> GetBookByIdAsync(Guid id)
        {
            return await context.Books
                .Include(b => b.Author)
                .Include(b => b.Category)
                .Include(b => b.Images)
                .FirstOrDefaultAsync(b => b.Id == id);
        }

        public async Task<IEnumerable<Book>> SearchBookByTitleAsync(string title)
        {
            return await context.Books
                .Include(b => b.Author)
                .Include(b => b.Category)
                .Include(b => b.Images)
                .Where(b => b.Title.StartsWith(title, StringComparison.CurrentCultureIgnoreCase))
                .ToListAsync();
        }

        public async Task UpdateBookAsync(Book book)
        {
            context.Books.Update(book);
            await context.SaveChangesAsync();
        }
    }
}
