using OnlineShopping.Infrastructure.Entities;

namespace OnlineShopping.Infrastructure.IRepositories;

/// <summary>
/// User Interface
/// </summary>
public interface IUserRepository
{
    Task<IEnumerable<User>> GetAll();
    Task<User> GetById(int id);
    Task Create(User user);
    Task Update(User user);
    void Delete(User user);
    Task<bool> SaveChangesAsync();
}
