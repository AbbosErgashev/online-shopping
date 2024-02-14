using OnlineShopping.Businnes.Models.WarehouseProductModel;
using OnlineShopping.Infrastructure.Entities.Warehouses;

namespace OnlineShopping.Businnes.IServices;

public interface IWarehouseProductService
{
    Task<IEnumerable<ReadWarehouseProductModel>> GetAllService();
    Task<ReadWarehouseProductModel> GetByIdService(int id);
    Task<ReadWarehouseProductModel> CreateService(CreateWarehouseProductModel warehouseProduct);
    Task UpdateService(int id, UpdateWarehouseProductModel warehouseProduct);
    Task DeleteService(int id);
}
