using Microsoft.EntityFrameworkCore;
using OnlineShopping.Infrastructure.Datas;
using OnlineShopping.Infrastructure.Entities.Warehouses;
using OnlineShopping.Infrastructure.IRepositories;

namespace OnlineShopping.Infrastructure.Repositories;

public class WarehouseProductRepository : IWarehouseProductRepository
{
    private readonly ApplicationContext _context;

    public WarehouseProductRepository(ApplicationContext context) => _context = context;

    public async Task CreateRepository(WarehouseProduct warehouseProduct)
    {
        await _context.WarehouseProducts.AddAsync(warehouseProduct);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteRepository(WarehouseProduct warehouseProduct)
    {
        _context.WarehouseProducts.Remove(warehouseProduct);
        await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<WarehouseProduct>> GetAllRepository()
    {
        var getAll = await _context.WarehouseProducts.ToListAsync();
        return getAll;
    }

    public async Task<WarehouseProduct> GetByIdRepository(int id)
    {
        var getById = await _context.WarehouseProducts.FirstOrDefaultAsync(x => x.Id == id);
        return getById;
    }

    public async Task<bool> SaveChangesAsync()
    {
        var save = await _context.SaveChangesAsync() > 0;
        return save;
    }

    public async Task UpdateRepository(WarehouseProduct warehouseProduct)
    {
        await _context.SaveChangesAsync();
    }
}
