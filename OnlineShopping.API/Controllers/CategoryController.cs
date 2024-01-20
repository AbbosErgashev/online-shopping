using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OnlineShopping.Businnes.Models.CategoryModel;
using OnlineShopping.Infrastructure.Entities;
using OnlineShopping.Infrastructure.IRepositories;

namespace OnlineShopping.API.Controllers;

[Route("api/[controller]")]
[ApiController]

public class CategoryController : ControllerBase
{
    private readonly IMapper mapper;
    private readonly ICategoryRepository category;

    public CategoryController(IMapper mapper, ICategoryRepository category)
    {
        this.mapper = mapper;
        this.category = category;
    }

    [HttpPost]
    public async Task<IActionResult> Create(CategoryCreateDTO create)
    {
        var createCategory = mapper.Map<Category>(create);

        await category.Create(createCategory);

        await category.SaveChangesAsync();

        return Created("", createCategory);
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var getAll = await category.GetAll();

        if (category is null)
            return NoContent();

        return Ok(mapper.Map<IEnumerable<CategoryReadDTO>>(getAll));
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var getById = await category.GetById(id);

        if (getById is null)
            return NotFound();

        await category.SaveChangesAsync();

        return Ok(mapper.Map<CategoryReadDTO>(getById));
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var getByIdDelete = await category.GetById(id);

        if (getByIdDelete is null)
            return NoContent();

        category.Delete(getByIdDelete);

        await category.SaveChangesAsync();

        return NoContent(); 
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, CategoryUpdateDTO updateCategory)
    {
        var getByIdUpdate = await category.GetById(id);

        if (getByIdUpdate is null)
            return NotFound();

        mapper.Map(updateCategory, getByIdUpdate);

        await category.Update(getByIdUpdate);

        await category.SaveChangesAsync();

        return NoContent();
    }
}
