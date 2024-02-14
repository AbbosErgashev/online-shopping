using OnlineShopping.Infrastructure.Entities.Warehouses;

namespace OnlineShopping.Infrastructure.IRepositories;

public interface IWarehouseProductRepository
{
    Task<IEnumerable<WarehouseProduct>> GetAllRepository();
    Task<WarehouseProduct> GetByIdRepository(int id);
    Task CreateRepository(WarehouseProduct warehouseProduct);
    Task UpdateRepository(WarehouseProduct warehouseProduct);
    Task DeleteRepository(WarehouseProduct warehouseProduct);
    Task<bool> SaveChangesAsync();
}
