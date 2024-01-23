using Microsoft.AspNetCore.Mvc;
using OnlineShopping.Businnes.IServices;
using OnlineShopping.Businnes.Models.CategoryModel;

namespace OnlineShopping.API.Controllers;

[Route("api/[controller]")]
[ApiController]

public class CategoryController : ControllerBase
{
    private readonly ICategoryService _category;

    public CategoryController(ICategoryService category)
    {
        _category = category;
    }

    [HttpPost("create")]
    public async Task<IActionResult> Create(CategoryCreateDTO create)
    {
        try
        {
            await _category.CreateCategory(create);
            return Ok(create);
        }
        catch
        {
            return BadRequest("user not created");
        }
    }

    [HttpGet("get-all")]
    public async Task<IActionResult> GetAll()
    {
        try
        {
            var getAll = await _category.GetCategoriesAsync();
            return Ok(getAll);
        }
        catch
        {
            return BadRequest("categories not found");
        }
    }

    [HttpGet("get-by-id")]
    public async Task<IActionResult> GetById(int id)
    {
        try
        {
            var result = await _category.GetCategoryById(id);
            return Ok(result);
        }
        catch
        {
            return BadRequest("category not found");
        }
    }

    [HttpDelete("delete")]
    public async Task<IActionResult> Delete(int id)
    {
        try
        {
            await _category.DeleteCategory(id);
            return Ok("category deleted");
        }
        catch
        {
            return BadRequest("category not found");
        }
    }

    [HttpPut("update")]
    public async Task<IActionResult> Update(int id, CategoryUpdateDTO updateCategory)
    {
        try
        {
            await _category.UpdateCategory(id, updateCategory);
            return Ok(updateCategory);
        }
        catch
        {
            return BadRequest("category not found also not deleted");
        }
    }
}
