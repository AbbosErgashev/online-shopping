using OnlineShopping.Infrastructure.Entities;

namespace OnlineShopping.Infrastructure.IRepositories;

public interface IUserRepository
{
    Task<IEnumerable<User>> GetAllRepository();
    Task<User> GetByIdRepository(int id);
    Task CreateRepository(User user);
    Task UpdateRepository(User user);
    void DeleteRepository(User user);
    Task<bool> SaveChangesAsyncUser();
}
