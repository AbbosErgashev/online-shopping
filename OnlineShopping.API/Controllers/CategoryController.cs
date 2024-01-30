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
    public async Task<IActionResult> CreateCreategory(CategoryCreateModel create)
    {
        try
        {
            await _category.CreateCategoryService(create);
            return Ok(create);
        }
        catch
        {
            return BadRequest("user not created");
        }
    }

    [HttpGet("get-all")]
    public async Task<IActionResult> GetAllCategories()
    {
        try
        {
            var getAll = await _category.GetAllCategoryService();
            return Ok(getAll);
        }
        catch
        {
            return BadRequest("categories not found");
        }
    }

    [HttpGet("get-by-id")]
    public async Task<IActionResult> GetByIdCategory(int id)
    {
        try
        {
            var result = await _category.GetCategoryByIdService(id);
            return Ok(result);
        }
        catch
        {
            return BadRequest("category not found");
        }
    }

    [HttpDelete("delete")]
    public async Task<IActionResult> DeleteCategory(int id)
    {
        try
        {
            await _category.DeleteCategoryService(id);
            return Ok("category deleted");
        }
        catch
        {
            return BadRequest("category not found");
        }
    }

    [HttpPut("update")]
    public async Task<IActionResult> UpdateCategory(int id, CategoryUpdateModel updateCategory)
    {
        try
        {
            await _category.UpdateCategoryService(id, updateCategory);
            return Ok(updateCategory);
        }
        catch
        {
            return BadRequest("category not found also not deleted");
        }
    }
}
