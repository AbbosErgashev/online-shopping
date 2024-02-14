using OnlineShopping.Businnes.Models.CategoryModel;

namespace OnlineShopping.Businnes.IServices;

public interface ICategoryService
{
    Task<IEnumerable<ReadCategoryModel>> GetAllService();
    Task<ReadCategoryModel> GetByIdService(int id);
    Task<ReadCategoryModel> CreateService(CreateCategoryModel category);
    Task UpdateService(int id, UpdateCategoryModel category);
    Task DeleteService(int id);
}
