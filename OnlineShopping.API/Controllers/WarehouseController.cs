using Microsoft.AspNetCore.Mvc;
using OnlineShopping.Businnes.IServices;
using OnlineShopping.Businnes.Models.WarehouseModel;

namespace OnlineShopping.API.Controllers;

[Route("api/[controller]")]
[ApiController]

public class WarehouseController : ControllerBase
{
    private readonly IWarehouseService _service;

    public WarehouseController(IWarehouseService service)
    {
        _service = service;
    }

    [HttpPost("create")]
    public async Task<IActionResult> CreateWarehouse(CreateWarehouseModel createWarehouseDTO)
    {
        return Created("", await _service.CreateWarehouseService(createWarehouseDTO));
    }

    [HttpGet("get")]
    public async Task<IActionResult> GetAllWarehouses()
    {
        var getAll = await _service.GetAllWarehousesService();
        return Ok(getAll);
    }


    [HttpGet("get-by-id")]
    public async Task<IActionResult> GetByIdWarehouse(int id)
    {
        var getByid = await _service.GetWarehouseByIdService(id);
        return Ok(getByid);
    }

    [HttpDelete("delete")]
    public async Task<IActionResult> DeleteWarehouse(int id)
    {
        await _service.DeleteWarehouseService(id);
        return Ok();
    }

    [HttpPut("update")]
    public async Task<IActionResult> UpdateWarehouse(int id, UpdateCategoryModel updateDTO)
    {
        await _service.UpdateWarehouseService(id, updateDTO);
        return Ok(updateDTO);
    }
}
