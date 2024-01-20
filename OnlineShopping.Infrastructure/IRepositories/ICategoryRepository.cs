using OnlineShopping.Infrastructure.Entities;

namespace OnlineShopping.Infrastructure.IRepositories;

/// <summary>
/// Category Interface
/// </summary>
public interface ICategoryRepository
{
    Task<IEnumerable<Category>> GetAll();
    Task<Category?> GetById(int id);
    Task Create(Category category);
    Task Update(Category category);
    void Delete(Category category);
    Task<bool> SaveChangesAsync();
}
