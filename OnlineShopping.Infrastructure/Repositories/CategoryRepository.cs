using Microsoft.EntityFrameworkCore;
using OnlineShopping.Infrastructure.Datas;
using OnlineShopping.Infrastructure.Entities;
using OnlineShopping.Infrastructure.IRepositories;

namespace OnlineShopping.Infrastructure.Repositories;

/// <summary>
/// Category Repository
/// </summary>
public class CategoryRepository : ICategoryRepository
{
    private readonly ApplicationContext context;

    public CategoryRepository(ApplicationContext context) => this.context = context;

    public async Task CreateCategoryRepository(Category category)
    {
        if(category is null) throw new ArgumentNullException(nameof(category));

        await context.AddAsync(category);
    }

    public void DeleteCategoryRepository(Category category)
    {
        if(category is null) throw new ArgumentNullException(nameof(category));

        context.Remove(category);
    }

    public async Task<IEnumerable<Category>> GetAllCategories()
    {
        return await context.Categories.ToListAsync();
    }

    public async Task<Category> GetCategoryById(int id)
    {
        return await context.Categories.FirstOrDefaultAsync(x => x.CategoryId == id)
                                                            ?? throw new ArgumentNullException(nameof(id));
    }

    public async Task<bool> SaveChangesAsyncCategory()
    {
        return await context.SaveChangesAsync() > 0;
    }

    public async Task UpdateCategoryRepository(Category category)
    {
        if (category is null) throw new ArgumentNullException(nameof(category));

        await context.SaveChangesAsync();
    }
}
