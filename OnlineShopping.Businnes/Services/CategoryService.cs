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

    public async Task CreateCategoryService(CategoryCreateModel category)
    {
        var createCategory = _mapper.Map<Category>(category);

        await _categoryRepository.CreateCategoryRepository(createCategory);

        await _categoryRepository.SaveChangesAsyncCategory();
    }

    public async Task DeleteCategoryService(int id)
    {
        var getCategoryById = await _categoryRepository.GetCategoryById(id);

        if (getCategoryById is null) 
            throw new ArgumentNullException(nameof(getCategoryById));

        _categoryRepository.DeleteCategoryRepository(getCategoryById);

        await _categoryRepository.SaveChangesAsyncCategory();
    }

    public async Task<IEnumerable<CategoryReadModel>> GetAllCategoryService()
    {
        var getAll = await _categoryRepository.GetAllCategories();

        if (getAll is null) 
            throw new ArgumentNullException(nameof(getAll));

        var mapped = _mapper.Map<IEnumerable<CategoryReadModel>>(getAll);

        return mapped;
    }

    public async Task<CategoryReadModel> GetCategoryByIdService(int id)
    {
        var getById = await _categoryRepository.GetCategoryById(id);

        if (getById is null) 
            throw new ArgumentNullException(nameof(getById));

        var mapped = _mapper.Map<CategoryReadModel>(getById);

        return mapped;
    }

    public async Task UpdateCategoryService(int id, CategoryUpdateModel category)
    {
        var getById = await _categoryRepository.GetCategoryById(id);

        if (getById is null) 
            throw new ArgumentNullException(nameof(getById));

        _mapper.Map(category, getById);

        await _categoryRepository.UpdateCategoryRepository(getById);

        await _categoryRepository.SaveChangesAsyncCategory();
    }
}
