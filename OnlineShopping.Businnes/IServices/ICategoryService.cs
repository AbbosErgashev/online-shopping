using OnlineShopping.Businnes.Models.CategoryModel;

namespace OnlineShopping.Businnes.IServices;

public interface ICategoryService
{
    Task<IEnumerable<CategoryReadDTO>> GetCategoriesAsync();
    Task<CategoryReadDTO> GetCategoryById(int id);
    Task CreateCategory(CategoryCreateDTO category);
    Task UpdateCategory(int id, CategoryUpdateDTO category);
    Task DeleteCategory(int id);
}
