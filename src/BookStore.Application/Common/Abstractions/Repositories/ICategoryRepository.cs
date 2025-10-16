using BookStore.Domain.Entities;

namespace BookStore.Application.Common.Abstractions.Repositories
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetAllCategoriesAsync();
        Task<Category?> GetCategoryByIdAsync(int id);
    }
}
