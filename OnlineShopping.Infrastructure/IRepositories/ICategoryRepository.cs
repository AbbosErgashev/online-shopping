using OnlineShopping.Infrastructure.Entities;

namespace OnlineShopping.Infrastructure.IRepositories;

/// <summary>
/// Category Interface
/// </summary>
public interface ICategoryRepository
{
    Task<IEnumerable<Category>> GetAllCategories();
    Task<Category> GetCategoryById(int id);
    Task CreateCategoryRepository(Category category);
    Task UpdateCategoryRepository(Category category);
    Task DeleteCategoryRepository(Category category);
    Task<bool> SaveChangesAsync();
}
