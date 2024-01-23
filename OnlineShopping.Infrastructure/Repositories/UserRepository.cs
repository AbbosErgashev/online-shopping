using Microsoft.EntityFrameworkCore;
using OnlineShopping.Infrastructure.Datas;
using OnlineShopping.Infrastructure.Entities;
using OnlineShopping.Infrastructure.IRepositories;

namespace OnlineShopping.Infrastructure.Repositories;

public class UserRepository : IUserRepository
{
    private readonly ApplicationContext _context;

    public UserRepository(ApplicationContext context) => _context = context;

    public async Task CreateUserRepository(User user)
    {
        if (user is null) throw new ArgumentNullException(nameof(user));

        await _context.Users.AddAsync(user);
    }

    public void DeleteUserRepository(User user)
    {
        _context.Users.Remove(user);
    }

    public async Task<IEnumerable<User>> GetAllUsers()
    {
        return await _context.Users.ToListAsync();
    }

#pragma warning disable
    public async Task<User> GetUserById(int id)
    {
        return await _context.Users.FirstOrDefaultAsync(x => x.UserId == id);
    }

    public async Task<bool> SaveChangesAsync()
    {
        return await _context.SaveChangesAsync() > 0;
    }
    public async Task UpdateUserRepository(User user)
    {
        if (user is null) throw new ArgumentNullException(nameof(user));

        await _context.SaveChangesAsync();
    }
}
