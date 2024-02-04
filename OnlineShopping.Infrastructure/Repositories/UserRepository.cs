using Microsoft.EntityFrameworkCore;
using OnlineShopping.Infrastructure.Datas;
using OnlineShopping.Infrastructure.Entities;
using OnlineShopping.Infrastructure.IRepositories;

namespace OnlineShopping.Infrastructure.Repositories;

public class UserRepository : IUserRepository
{
    private readonly ApplicationContext _context;

    public UserRepository(ApplicationContext context) => _context = context;

    public async Task<IEnumerable<User>> GetAllRepository()
    {
        var create = await _context.Users.ToListAsync();
        return create;
    }

    public async Task<User> GetByIdRepository(int id)
    {
        var getById = await _context.Users.FirstOrDefaultAsync(x => x.Id == id);
        return getById;
    }

    public async Task CreateRepository(User user)
    {
        await _context.Users.AddAsync(user);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteRepository(User user)
    {
        _context.Users.Remove(user);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateRepository(User user)
    {
        await _context.SaveChangesAsync();
    }

    public async Task<bool> SaveChangesAsyncUser()
    {
        return await _context.SaveChangesAsync() > 0;
    }
}
