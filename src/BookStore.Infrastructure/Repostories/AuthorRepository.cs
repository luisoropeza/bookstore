using BookStore.Application.Common.Abstractions.Repositories;
using BookStore.Domain.Entities;
using BookStore.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Infrastructure.Repostories
{
    public class AuthorRepository (BookStoreDbContext context) : IAuthorRepository
    {
        public async Task<IEnumerable<Author>> GetAllAuthorsAsync()
        {
            return await context.Authors
                .Include(a => a.Books)
                    .ThenInclude(b => b.Images)
                .AsSplitQuery()
                .ToListAsync();
        }

        public async Task<Author?> GetAuthorByIdAsync(int id)
        {
            return await context.Authors
                .Include(a => a.Books)
                    .ThenInclude(b => b.Images)
                .AsSplitQuery()
                .FirstOrDefaultAsync(a => a.Id == id);
        }

        public async Task CreateAuthorAsync(Author author)
        {
            context.Authors.Add(author);
            await context.SaveChangesAsync();
        }

        public async Task UpdateAuthorAsync(Author author)
        {
            context.Authors.Update(author);
            await context.SaveChangesAsync();
        }
    }
}
