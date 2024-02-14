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
        return Created("", await _service.CreateService(createWarehouseDTO));
    }

    [HttpGet("get")]
    public async Task<IActionResult> GetAllWarehouses()
    {
        var getAll = await _service.GetAllService();
        return Ok(getAll);
    }


    [HttpGet("get-by-id")]
    public async Task<IActionResult> GetByIdWarehouse(int id)
    {
        var getByid = await _service.GetByIdService(id);
        return Ok(getByid);
    }

    [HttpDelete("delete")]
    public async Task<IActionResult> DeleteWarehouse(int id)
    {
        await _service.DeleteService(id);
        return Ok();
    }

    [HttpPut("update")]
    public async Task<IActionResult> UpdateWarehouse(int id, UpdateWarehouseModel updateDTO)
    {
        await _service.UpdateService(id, updateDTO);
        return Ok(updateDTO);
    }
}
