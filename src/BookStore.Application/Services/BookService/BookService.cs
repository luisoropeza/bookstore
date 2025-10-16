using AutoMapper;
using BookStore.Application.Common.Abstractions.Repositories;
using BookStore.Application.DataTransferObjects.BookDto;
using BookStore.Domain.Entities;

namespace BookStore.Application.Services.BookService
{
    public class BookService(IBookRepository repository, IMapper mapper) : IBookService
    {
        public async Task AddDiscountAsync(Guid id, BookAddDiscountRequest request)
        {
            var book = await FindBookById(id);
            book.Discount = request.Discount;
            await repository.UpdateBookAsync(book);
        }

        public async Task AddStockAsync(Guid id, BookAddStockRequest request)
        {
            var book = await FindBookById(id);
            book.Stock += request.Stock;
            await repository.UpdateBookAsync(book);
        }

        public async Task CreateBookAsync(BookRequest request)
        {
            var book = mapper.Map<Book>(request);
            await repository.CreateBookAsync(book);
        }

        public async Task<IEnumerable<BookResponse>> GetAllBooksAsync()
        {
            var books = await repository.GetAllBooksAsync();
            return mapper.Map<IEnumerable<BookResponse>>(books);
        }

        public async Task<BookResponse> GetBookByIdAsync(Guid id)
        {
            var book = await FindBookById(id);
            return mapper.Map<BookResponse>(book);
        }

        public async Task RemoveDiscountAsync(Guid id)
        {
            var book = await FindBookById(id);
            book.Discount = 0;
            await repository.UpdateBookAsync(book);
        }

        public async Task<IEnumerable<BookResponse>> SearchBooksByTitleAsync(string title)
        {
            var books = await repository.SearchBookByTitleAsync(title);
            return mapper.Map<IEnumerable<BookResponse>>(books);
        }

        public async Task UpdateBookAsync(Guid id, BookRequest request)
        {
            var book = await FindBookById(id);
            await repository.UpdateBookAsync(mapper.Map(request, book));
        }

        private async Task<Book> FindBookById(Guid id)
        {
            return await repository.GetBookByIdAsync(id) ?? throw new KeyNotFoundException("No se encontro el libro");
        }
    }
}
