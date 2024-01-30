using OnlineShopping.Businnes.Models.CategoryModel;

namespace OnlineShopping.Businnes.IServices;

public interface ICategoryService
{
    Task<IEnumerable<CategoryReadModel>> GetAllCategoryService();
    Task<CategoryReadModel> GetCategoryByIdService(int id);
    Task CreateCategoryService(CategoryCreateModel category);
    Task UpdateCategoryService(int id, CategoryUpdateModel category);
    Task DeleteCategoryService(int id);
}
