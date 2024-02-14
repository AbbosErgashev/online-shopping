using OnlineShopping.Infrastructure.Entities.Warehouses;

namespace OnlineShopping.Infrastructure.IRepositories;

public interface IWarehouseRepository
{
    Task<IEnumerable<Warehouse>> GetAllRepository();
    Task<Warehouse> GetByIdRepository(int id);
    Task CreateRepository(Warehouse warehouse);
    Task UpdateRepository(Warehouse warehouse);
    Task DeleteRepository(Warehouse warehouse);
    Task<bool> SaveChangesAsync();
}
