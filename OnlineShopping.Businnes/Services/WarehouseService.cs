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

    public async Task<IEnumerable<ReadWarehouseModel>> GetAllService()
    {
        try
        {
            var getAll = await _repository.GetAllRepository();
            var mapped = _mapper.Map<IEnumerable<ReadWarehouseModel>>(getAll);
            return mapped;
        }
        catch
        {
            throw new Exception("Warehouses not found");
        }
    }

    public async Task<ReadWarehouseModel> GetByIdService(int id)
    {
        try
        {
            var getById = await _repository.GetByIdRepository(id);
            var mapped = _mapper.Map<ReadWarehouseModel>(getById);
            return mapped;
        }
        catch
        {
            throw new Exception("Warehouse not found");
        }

    }

    public async Task<ReadWarehouseModel> CreateService(CreateWarehouseModel createDTO)
    {
        try
        {
            var create = _mapper.Map<Warehouse>(createDTO);
            await _repository.CreateRepository(create);
            var mapped = _mapper.Map<ReadWarehouseModel>(create);
            return mapped;
        }
        catch
        {
            throw new Exception("Warehouse not created");
        }
    }


    public async Task DeleteService(int id)
    {
        var getById = await _repository.GetByIdRepository(id);
        if (getById is null)
            throw new Exception("Warehouse not found");

        await _repository.DeleteRepository(getById);
        await _repository.UpdateRepository(getById);
        await _repository.SaveChangesAsync();
        _mapper.Map<ReadWarehouseModel>(getById);
    }

    public async Task UpdateService(int id, UpdateWarehouseModel updateDTO)
    {
        var getById = await _repository.GetByIdRepository(id);
        if (getById is null)
            throw new Exception("Warehouse not found");

        _mapper.Map(updateDTO, getById);
        await _repository.UpdateRepository(getById);
        await _repository.SaveChangesAsync();
        _mapper.Map<ReadWarehouseModel>(getById);
    }
}
