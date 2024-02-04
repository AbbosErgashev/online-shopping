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

    public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
    {
        _categoryRepository = categoryRepository;
        _mapper = mapper;
    }

    public async Task<CategoryReadModel> CreateCategoryService(CategoryCreateModel categoryDto)
    {
        try
        {
            var create = _mapper.Map<Category>(categoryDto);
            await _categoryRepository.CreateCategoryRepository(create);
            var mapped = _mapper.Map<CategoryReadModel>(create);
            return mapped;
        }
        catch
        {
            throw new Exception("Category not created");
        }
    }

    public async Task DeleteCategoryService(int id)
    {
        try
        {
            var delete = await _categoryRepository.GetCategoryById(id);
            if (delete is null)
                throw new Exception("Category not found");
            await _categoryRepository.DeleteCategoryRepository(delete);
            _mapper.Map<CategoryReadModel>(delete);
            await _categoryRepository.SaveChangesAsync();
        }
        catch
        {
            throw new Exception("Category not deleted");
        }
    }

    public async Task<IEnumerable<CategoryReadModel>> GetAllCategoriesService()
    {
        try
        {
            var getAll = await _categoryRepository.GetAllCategories();
            var mapped = _mapper.Map<IEnumerable<CategoryReadModel>>(getAll);
            return mapped;
        }
        catch
        {
            throw new Exception("Categories not found");
        }
    }

    public async Task<CategoryReadModel> GetCategoryByIdService(int id)
    {
        var getById = await _categoryRepository.GetCategoryById(id);
        if (getById is null)
            throw new Exception("Category not found");
        var mapped = _mapper.Map<CategoryReadModel>(getById);
        return mapped;
    }

    public async Task UpdateCategoryService(int id, CategoryUpdateModel category)
    {
        var update = await _categoryRepository.GetCategoryById(id);
        if (update is null)
            throw new Exception("Category nor found");
        _mapper.Map(category, update);
        await _categoryRepository.UpdateCategoryRepository(update);
        _mapper.Map<CategoryReadModel>(update);
        await _categoryRepository.SaveChangesAsync();
    }
}
