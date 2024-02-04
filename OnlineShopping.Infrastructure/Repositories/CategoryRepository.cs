using Microsoft.EntityFrameworkCore;
using OnlineShopping.Infrastructure.Datas;
using OnlineShopping.Infrastructure.Entities;
using OnlineShopping.Infrastructure.IRepositories;

namespace OnlineShopping.Infrastructure.Repositories;

public class CategoryRepository : ICategoryRepository
{
    private readonly ApplicationContext _context;

    public CategoryRepository(ApplicationContext context) => _context = context;

    public async Task CreateCategoryRepository(Category category)
    {
        await _context.AddAsync(category);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteCategoryRepository(Category category)
    {
        _context.Categories.Remove(category);
        await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<Category>> GetAllCategories()
    {
        return await _context.Categories.ToListAsync();
    }

    public async Task<Category> GetCategoryById(int id)
    {
        var getById = await _context.Categories.FirstOrDefaultAsync(x => x.Id == id);
        return getById;
    }

    public async Task<bool> SaveChangesAsync()
    {
        return await _context.SaveChangesAsync() > 0;
    }

    public async Task UpdateCategoryRepository(Category category)
    {
        await _context.SaveChangesAsync();
    }
}
