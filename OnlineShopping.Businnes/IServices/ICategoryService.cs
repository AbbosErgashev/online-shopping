using OnlineShopping.Businnes.Models.CategoryModel;

namespace OnlineShopping.Businnes.IServices;

public interface ICategoryService
{
    Task<IEnumerable<CategoryReadModel>> GetAllCategoriesService();
    Task<CategoryReadModel> GetCategoryByIdService(int id);
    Task<CategoryReadModel> CreateCategoryService(CategoryCreateModel category);
    Task UpdateCategoryService(int id, CategoryUpdateModel category);
    Task DeleteCategoryService(int id);
}
