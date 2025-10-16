using AutoMapper;
using BookStore.Application.Common.Abstractions.Repositories;
using BookStore.Application.DataTransferObjects.AuthorDto;
using BookStore.Domain.Entities;

namespace BookStore.Application.Services.AuthorService
{
    public class AuthorService(IAuthorRepository repository, IMapper mapper) : IAuthorService
    {
        public async Task CreateAuthorAsync(AuthorRequest request)
        {
            var author = mapper.Map<Author>(request);
            await repository.CreateAuthorAsync(author);
        }

        public async Task<IEnumerable<AuthorWithCantBooksResponse>> GetAllAuthorsAsync()
        {
            var authors = await repository.GetAllAuthorsAsync();
            return mapper.Map<IEnumerable<AuthorWithCantBooksResponse>>(authors);
        }

        public async Task<AuthorWithBooksResponse> GetAuthorByIdAsync(int id)
        {
            var author = await FindAuthorById(id);
            return mapper.Map<AuthorWithBooksResponse>(author);
        }

        public async Task UpdateAuhorAsync(int id, AuthorRequest request)
        {
            var author = await FindAuthorById(id);
            await repository.UpdateAuthorAsync(mapper.Map(request, author));
        }

        private async Task<Author> FindAuthorById(int id)
        {
            return await repository.GetAuthorByIdAsync(id) ?? throw new KeyNotFoundException("No se encontro al autor");
        }
    }
}
