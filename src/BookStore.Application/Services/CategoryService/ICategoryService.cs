using BookStore.Application.DataTransferObjects.CategoryDto;

namespace BookStore.Application.Services.CategoryService
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryWithCantBooksResponse>> GetAllCategoriesAsync();
        Task<CategoryWithBooksResponse> GetCategoryByIdAsync(int id);
    }
}
