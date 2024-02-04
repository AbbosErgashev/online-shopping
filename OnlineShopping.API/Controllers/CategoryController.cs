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
    public async Task<IActionResult> CreateCreategory(CategoryCreateModel create)
    {
        return Created("", await _category.CreateCategoryService(create));
    }

    [HttpGet("get-all")]
    public async Task<IActionResult> GetAllCategories()
    {
        var getAll = await _category.GetAllCategoriesService();
        return Ok(getAll);
    }

    [HttpGet("get-by-id")]
    public async Task<IActionResult> GetByIdCategory(int id)
    {
        var result = await _category.GetCategoryByIdService(id);
        return Ok(result);
    }

    [HttpDelete("delete")]
    public async Task<IActionResult> DeleteCategory(int id)
    {
        await _category.DeleteCategoryService(id);
        return Ok();
    }

    [HttpPut("update")]
    public async Task<IActionResult> UpdateCategory(int id, CategoryUpdateModel updateCategory)
    {
        await _category.UpdateCategoryService(id, updateCategory);
        return Ok(updateCategory);
    }
}
