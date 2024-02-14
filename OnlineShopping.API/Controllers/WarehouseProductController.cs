using Microsoft.AspNetCore.Mvc;
using OnlineShopping.Businnes.IServices;
using OnlineShopping.Businnes.Models.WarehouseProductModel;

namespace OnlineShopping.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class WarehouseProductController : ControllerBase
{
    private readonly IWarehouseProductService _service;

    public WarehouseProductController(IWarehouseProductService service) => _service = service;

    [HttpPost("create")]
    public async Task<IActionResult> CreateWarehouseProduct(CreateWarehouseProductModel create)
    {
        return Created("", await _service.CreateService(create));
    }

    [HttpGet("get-all")]
    public async Task<IActionResult> GetAllWarehouseProduct()
    {
        var getAll = await _service.GetAllService();
        return Ok(getAll);
    }

    [HttpGet("get-by-id")]
    public async Task<IActionResult> GetByIdWarehouseProduct(int id)
    {
        var getById = await _service.GetByIdService(id);
        return Ok(getById);
    }

    [HttpDelete("delete")]
    public async Task<IActionResult> DeleteWarehouseProduct(int id)
    {
        await _service.DeleteService(id);
        return Ok();
    }

    [HttpPut("update")]
    public async Task<IActionResult> UpdateWarehouseProduct(int id, UpdateWarehouseProductModel update)
    {
        await _service.UpdateService(id, update);
        return Ok(update);
    }
}