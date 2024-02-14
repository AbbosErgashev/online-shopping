using OnlineShopping.Infrastructure.Entities;

namespace OnlineShopping.Infrastructure.IRepositories;

public interface ICategoryRepository
{
    Task<IEnumerable<Category>> GetAllCategories();
    Task<Category> GetById(int id);
    Task CreateRepository(Category category);
    Task UpdateRepository(Category category);
    Task DeleteRepository(Category category);
    Task<bool> SaveChangesAsync();
}
