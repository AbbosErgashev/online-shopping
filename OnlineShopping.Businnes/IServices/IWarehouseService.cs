using OnlineShopping.Businnes.Models.WarehouseModel;

namespace OnlineShopping.Businnes.IServices;

public interface IWarehouseService
{
    Task<IEnumerable<ReadWarehouseModel>> GetAllWarehousesService();
    Task<ReadWarehouseModel> GetWarehouseByIdService(int id);
    Task<ReadWarehouseModel> CreateWarehouseService(CreateWarehouseModel createDTO);
    Task UpdateWarehouseService(int id, UpdateCategoryModel updateDTO);
    Task DeleteWarehouseService(int id);
}
