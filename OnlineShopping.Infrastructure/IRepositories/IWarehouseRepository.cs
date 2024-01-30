using OnlineShopping.Infrastructure.Entities.Warehouses;

namespace OnlineShopping.Infrastructure.IRepositories;

public interface IWarehouseRepository
{
    Task<IEnumerable<Warehouse>> GetAllWarehousesRepository();
    Task<Warehouse> GetWarehouseByIdRepository(int id);
    Task CreateWarehouseRepository(Warehouse warehouse);
    Task UpdateWarehouseRepository(Warehouse warehouse);
    Task DeleteWarehouseRepository(Warehouse warehouse);
    Task<bool> SaveChangesAsyncRepository();
}
