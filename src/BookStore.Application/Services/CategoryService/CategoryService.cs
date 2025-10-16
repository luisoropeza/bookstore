using AutoMapper;
using BookStore.Application.Common.Abstractions.Repositories;
using BookStore.Application.DataTransferObjects.CategoryDto;
using BookStore.Domain.Entities;

namespace BookStore.Application.Services.CategoryService
{
    public class CategoryService(ICategoryRepository repository, IMapper mapper) : ICategoryService
    {
        public async Task<IEnumerable<CategoryWithCantBooksResponse>> GetAllCategoriesAsync()
        {
            var categories = await repository.GetAllCategoriesAsync();
            return mapper.Map<IEnumerable<CategoryWithCantBooksResponse>>(categories);
        }

        public async Task<CategoryWithBooksResponse> GetCategoryByIdAsync(int id)
        {
            var category = await FindCategoryById(id);
            return mapper.Map<CategoryWithBooksResponse>(category);
        }

        private async Task<Category> FindCategoryById(int id)
        {
            return await repository.GetCategoryByIdAsync(id) ?? throw new KeyNotFoundException("No se encontro la categoria");
        }
    }
}
