using Microsoft.EntityFrameworkCore;
using OnlineShopping.Infrastructure.Datas;
using OnlineShopping.Infrastructure.Entities;
using OnlineShopping.Infrastructure.IRepositories;

namespace OnlineShopping.Infrastructure.Repositories;

public class UserRepository : IUserRepository
{
    private readonly ApplicationContext _context;

    public UserRepository(ApplicationContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<User>> GetAllRepository()
    {
        return await _context.Users.ToListAsync();
    }

    public async Task<User> GetByIdRepository(int id)
    {
        var result = await _context.Users.FirstOrDefaultAsync(x => x.Id == id);

        if (result == null)
            throw new Exception($"{nameof(User)} is not found");

        return result;
    }

    public async Task CreateRepository(User user)
    {
        if (user is null) 
            throw new ArgumentNullException(nameof(user));

        await _context.Users.AddAsync(user);

        await _context.SaveChangesAsync();
    }

    public async void DeleteRepository(User user)
    {
        _context.Users.Remove(user);

        await _context.SaveChangesAsync();
    }

    public async Task UpdateRepository(User user)
    {
        if (user is null) 
            throw new ArgumentNullException(nameof(user));

        await _context.SaveChangesAsync();
    }

    public async Task<bool> SaveChangesAsyncUser()
    {
        return await _context.SaveChangesAsync() > 0;
    }
}
