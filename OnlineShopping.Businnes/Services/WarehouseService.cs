using AutoMapper;
using OnlineShopping.Businnes.IServices;
using OnlineShopping.Businnes.Models.WarehouseModel;
using OnlineShopping.Infrastructure.Entities.Warehouses;
using OnlineShopping.Infrastructure.IRepositories;

namespace OnlineShopping.Businnes.Services;

public class WarehouseService : IWarehouseService
{
    private readonly IWarehouseRepository _repository;
    private readonly IMapper _mapper;

    public WarehouseService(IWarehouseRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<ReadWarehouseModel>> GetAllWarehousesService()
    {
        try
        {
            var getAll = await _repository.GetAllWarehousesRepository();
            var mapped = _mapper.Map<IEnumerable<ReadWarehouseModel>>(getAll);

            return mapped;
        }
        catch
        {
            throw new Exception("Warehouses not found");
        }
    }

    public async Task<ReadWarehouseModel> GetWarehouseByIdService(int id)
    {
        try
        {
            var getById = await _repository.GetWarehouseByIdRepository(id);

            var mapped = _mapper.Map<ReadWarehouseModel>(getById);

            return mapped;
        }
        catch
        {
            throw new Exception("Warehouse not found");
        }

    }

    public async Task<ReadWarehouseModel> CreateWarehouseService(CreateWarehouseModel createDTO)
    {
        try
        {
            var create = _mapper.Map<Warehouse>(createDTO);
            await _repository.CreateWarehouseRepository(create);

            var mapped = _mapper.Map<ReadWarehouseModel>(create);

            return mapped;
        }
        catch
        {
            throw new Exception("Warehouse not created");
        }
    }


    public async Task DeleteWarehouseService(int id)
    {
        var getById = await _repository.GetWarehouseByIdRepository(id);

        if (getById is null)
            throw new Exception("Warehouse not found");

        await _repository.DeleteWarehouseRepository(getById);

        await _repository.UpdateWarehouseRepository(getById);

        await _repository.SaveChangesAsyncRepository();

        _mapper.Map<ReadWarehouseModel>(getById);
    }

    public async Task UpdateWarehouseService(int id, UpdateCategoryModel updateDTO)
    {
        var getById = await _repository.GetWarehouseByIdRepository(id);

        if (getById is null)
            throw new Exception("Warehouse not found");

        _mapper.Map(updateDTO, getById);

        await _repository.UpdateWarehouseRepository(getById);

        await _repository.SaveChangesAsyncRepository();

        _mapper.Map<ReadWarehouseModel>(getById);
    }
}
