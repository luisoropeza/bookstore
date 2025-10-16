using BookStore.Application.Common.Abstractions.Repositories;
using BookStore.Domain.Entities;
using BookStore.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Infrastructure.Repostories
{
    public class CategoryRepository(BookStoreDbContext context) : ICategoryRepository
    {
        public async Task<IEnumerable<Category>> GetAllCategoriesAsync()
        {
            return await context.Categories
                .Include(c => c.Books)
                    .ThenInclude(b => b.Images)
                .AsSplitQuery()
                .ToListAsync();
        }

        public async Task<Category?> GetCategoryByIdAsync(int id)
        {
            return await context.Categories
                .Include(c => c.Books)
                    .ThenInclude(b => b.Images)
                .AsSplitQuery()
                .FirstOrDefaultAsync(c => c.Id == id);
        }
    }
}
