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
                .ToListAsync();
        }

        public async Task<Category?> GetCategoryByIdAsync(int id)
        {
            return await context.Categories
                .Include(c => c.Books)
                .FirstOrDefaultAsync(c => c.Id == id);
        }
    }
}
