using BookStore.Application.DataTransferObjects.AuthorDto;

namespace BookStore.Application.Services.AuthorService
{
    public interface IAuthorService
    {
        Task<IEnumerable<AuthorWithCantBooksResponse>> GetAllAuthorsAsync();
        Task<AuthorWithBooksResponse> GetAuthorByIdAsync(int id);
        Task CreateAuthorAsync(AuthorRequest request);
        Task UpdateAuhorAsync(int id, AuthorRequest request);
    }
}
