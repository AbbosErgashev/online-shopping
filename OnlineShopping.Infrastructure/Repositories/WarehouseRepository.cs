using Microsoft.EntityFrameworkCore;
using OnlineShopping.Infrastructure.Datas;
using OnlineShopping.Infrastructure.Entities.Warehouses;
using OnlineShopping.Infrastructure.IRepositories;
using System.Web.Http.Results;

namespace OnlineShopping.Infrastructure.Repositories;

public class WarehouseRepository : IWarehouseRepository
{
    private readonly ApplicationContext _context;

    public WarehouseRepository(ApplicationContext context) => _context = context;

    public async Task<IEnumerable<Warehouse>> GetAllRepository()
    {
        var getAll = await _context.Warehouses.ToListAsync();
        return getAll;
    }

    public async Task<Warehouse> GetByIdRepository(int id)
    {
        var getById = await _context.Warehouses.FirstOrDefaultAsync(x => x.Id == id)
            ?? throw new ArgumentNullException(nameof(id));

        return getById;
    }

    public async Task CreateRepository(Warehouse warehouse)
    {
        await _context.Warehouses.AddAsync(warehouse);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteRepository(Warehouse warehouse)
    {
        _context.Warehouses.Remove(warehouse);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateRepository(Warehouse warehouse)
    {
        await _context.SaveChangesAsync();
    }

    public async Task<bool> SaveChangesAsync()
    {
        return await _context.SaveChangesAsync() > 0;
    }
}
