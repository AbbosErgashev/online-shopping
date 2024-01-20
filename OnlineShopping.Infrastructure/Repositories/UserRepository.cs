using Microsoft.EntityFrameworkCore;
using OnlineShopping.Infrastructure.Datas;
using OnlineShopping.Infrastructure.Entities;
using OnlineShopping.Infrastructure.IRepositories;

namespace OnlineShopping.Infrastructure.Repositories;

public class UserRepository : IUserRepository
{
    private readonly ApplicationContext _context;

    public UserRepository(ApplicationContext context) => _context = context;

    public async Task Create(User user)
    {
        if (user is null) throw new ArgumentNullException(nameof(user));

        await _context.AddAsync(user);
    }

    public void Delete(User user)
    {
        if (user is null) throw new ArgumentNullException(nameof(user));

        _context.Users.Remove(user);
    }

    public async Task<IEnumerable<User>> GetAll() => await _context.Users.ToListAsync();

    public async Task<User> GetById(int id) => await _context.Users.FirstOrDefaultAsync(x => x.UserId == id)
                                                ?? throw new ArgumentException();

    public async Task<bool> SaveChangesAsync() => await _context.SaveChangesAsync() > 0;

    public async Task Update(User user)
    {
        if (user is null) throw new ArgumentNullException(nameof(user));

        await _context.SaveChangesAsync();
    }
}
