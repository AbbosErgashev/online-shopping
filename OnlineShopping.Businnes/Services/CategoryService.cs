using AutoMapper;
using OnlineShopping.Businnes.IServices;
using OnlineShopping.Businnes.Models.CategoryModel;
using OnlineShopping.Infrastructure.Entities;
using OnlineShopping.Infrastructure.IRepositories;

namespace OnlineShopping.Businnes.Services;

public class CategoryService : ICategoryService
{
    private readonly ICategoryRepository _categoryRepository;
    private readonly IMapper _mapper;

    public CategoryService(ICategoryRepository category, IMapper mapper)
    {
        _categoryRepository = category;
        _mapper = mapper;
    }

    public async Task<ReadCategoryModel> CreateService(CreateCategoryModel categoryDto)
    {
        try
        {
            var create = _mapper.Map<Category>(categoryDto);
            await _categoryRepository.CreateRepository(create);
            var mapped = _mapper.Map<ReadCategoryModel>(create);
            return mapped;
        }
        catch
        {
            throw new Exception("Category not created");
        }
    }

    public async Task DeleteService(int id)
    {
        try
        {
            var delete = await _categoryRepository.GetById(id);
            if (delete is null)
                throw new Exception("Category not found");

            await _categoryRepository.DeleteRepository(delete);
            _mapper.Map<ReadCategoryModel>(delete);
            await _categoryRepository.SaveChangesAsync();
        }
        catch
        {
            throw new Exception("Category not deleted");
        }
    }

    public async Task<IEnumerable<ReadCategoryModel>> GetAllService()
    {
        try
        {
            var getAll = await _categoryRepository.GetAllCategories();
            var mapped = _mapper.Map<IEnumerable<ReadCategoryModel>>(getAll);
            return mapped;
        }
        catch
        {
            throw new Exception("Categories not found");
        }
    }

    public async Task<ReadCategoryModel> GetByIdService(int id)
    {
        var getById = await _categoryRepository.GetById(id);
        if (getById is null)
            throw new Exception("Category not found");

        var mapped = _mapper.Map<ReadCategoryModel>(getById);
        return mapped;
    }

    public async Task UpdateService(int id, UpdateCategoryModel category)
    {
        var update = await _categoryRepository.GetById(id);
        if (update is null)
            throw new Exception("Category nor found");

        _mapper.Map(category, update);
        await _categoryRepository.UpdateRepository(update);
        _mapper.Map<ReadCategoryModel>(update);
        await _categoryRepository.SaveChangesAsync();
    }
}
