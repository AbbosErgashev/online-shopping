using OnlineShopping.Infrastructure.Entities;

namespace OnlineShopping.Infrastructure.IRepositories;

/// <summary>
/// User Interface
/// </summary>
public interface IUserRepository
{
    Task<IEnumerable<User>> GetAllUsers();
    Task<User> GetUserById(int id);
    Task CreateUserRepository(User user);
    Task UpdateUserRepository(User user);
    void DeleteUserRepository(User user);
    Task<bool> SaveChangesAsync();
}
