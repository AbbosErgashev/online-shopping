using OnlineShopping.Businnes.Models.WarehouseModel;

namespace OnlineShopping.Businnes.IServices;

public interface IWarehouseService
{
    Task<IEnumerable<ReadWarehouseModel>> GetAllService();
    Task<ReadWarehouseModel> GetByIdService(int id);
    Task<ReadWarehouseModel> CreateService(CreateWarehouseModel createDTO);
    Task UpdateService(int id, UpdateWarehouseModel updateDTO);
    Task DeleteService(int id);
}
