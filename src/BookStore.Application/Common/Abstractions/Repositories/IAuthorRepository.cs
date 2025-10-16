using BookStore.Domain.Entities;

namespace BookStore.Application.Common.Abstractions.Repositories
{
    public interface IAuthorRepository
    {
        Task<IEnumerable<Author>> GetAllAuthorsAsync();
        Task<Author?> GetAuthorByIdAsync(int id);
        Task CreateAuthorAsync(Author author);
        Task UpdateAuthorAsync(Author author);
    }
}
