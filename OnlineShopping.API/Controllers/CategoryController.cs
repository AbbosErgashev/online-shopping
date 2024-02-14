using Microsoft.AspNetCore.Mvc;
using OnlineShopping.Businnes.IServices;
using OnlineShopping.Businnes.Models.CategoryModel;

namespace OnlineShopping.API.Controllers;

[Route("api/[controller]")]
[ApiController]

public class CategoryController : ControllerBase
{
    private readonly ICategoryService _category;

    public CategoryController(ICategoryService category) => _category = category;


    [HttpPost("create")]
    public async Task<IActionResult> CreateCreategory(CreateCategoryModel create)
    {
        return Created("", await _category.CreateService(create));
    }

    [HttpGet("get-all")]
    public async Task<IActionResult> GetAllCategories()
    {
        var getAll = await _category.GetAllService();
        return Ok(getAll);
    }

    [HttpGet("get-by-id")]
    public async Task<IActionResult> GetByIdCategory(int id)
    {
        var result = await _category.GetByIdService(id);
        return Ok(result);
    }

    [HttpDelete("delete")]
    public async Task<IActionResult> DeleteCategory(int id)
    {
        await _category.DeleteService(id);
        return Ok();
    }

    [HttpPut("update")]
    public async Task<IActionResult> UpdateCategory(int id, UpdateCategoryModel updateCategory)
    {
        await _category.UpdateService(id, updateCategory);
        return Ok(updateCategory);
    }
}
