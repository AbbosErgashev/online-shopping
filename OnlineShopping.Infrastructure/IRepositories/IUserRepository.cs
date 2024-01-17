using OnlineShopping.Infrastructure.Entities;

namespace OnlineShopping.Infrastructure.IRepositories;

public interface IUserRepository
{
    public Task<IEnumerable<User>> GetAllUsers();
    public Task<User> GetUserById(int id);
    public Task CreateUser(User user);
    public Task UpdateUser(User user);
    public void DeleteUser(User user);
    public Task<bool> SaveChangesAsync();
}
