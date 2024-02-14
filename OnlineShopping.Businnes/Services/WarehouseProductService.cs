using AutoMapper;
using OnlineShopping.Businnes.IServices;
using OnlineShopping.Businnes.Models.WarehouseProductModel;
using OnlineShopping.Infrastructure.Entities.Warehouses;
using OnlineShopping.Infrastructure.IRepositories;

namespace OnlineShopping.Businnes.Services;

public class WarehouseProductService : IWarehouseProductService
{
    private readonly IWarehouseProductRepository _context;
    private readonly IMapper _mapper;

    public WarehouseProductService(IWarehouseProductRepository repository, IMapper mapper)
    {
        _context = repository;
        _mapper = mapper;
    }
    public async Task<ReadWarehouseProductModel> CreateService(CreateWarehouseProductModel warehouseProduct)
    {
        try
        {
            var create = _mapper.Map<WarehouseProduct>(warehouseProduct);
            await _context.CreateRepository(create);
            var mapped = _mapper.Map<ReadWarehouseProductModel>(create);
            return mapped;
        }
        catch
        {
            throw new Exception("Not created");
        }
    }

    public async Task DeleteService(int id)
    {
        try
        {
            var getById = await _context.GetByIdRepository(id);

            await _context.DeleteRepository(getById);
            _mapper.Map<ReadWarehouseProductModel>(getById);
            await _context.SaveChangesAsync();
        }
        catch
        {
            throw new Exception("Not found");
        }
    }

    public async Task<IEnumerable<ReadWarehouseProductModel>> GetAllService()
    {
        try
        {
            var getAll = await _context.GetAllRepository();
            var mapped = _mapper.Map<IEnumerable<ReadWarehouseProductModel>>(getAll);
            return mapped;
        }
        catch
        {
            throw new Exception("Not found");
        }
    }

    public async Task<ReadWarehouseProductModel> GetByIdService(int id)
    {
        var getById = await _context.GetByIdRepository(id);
        if (getById is null)
            throw new Exception("Not found");

        var mapped = _mapper.Map<ReadWarehouseProductModel>(getById);
        return mapped;
    }

    public async Task UpdateService(int id, UpdateWarehouseProductModel warehouseProduct)
    {
        var getById = await _context.GetByIdRepository(id);
        if (getById is null)
            throw new Exception("Not found");

        _mapper.Map(warehouseProduct, getById);
        await _context.UpdateRepository(getById);
        _mapper.Map<ReadWarehouseProductModel>(getById);
        await _context.SaveChangesAsync();
    }
}
