using Microsoft.AspNetCore.Mvc;
using OnlineShopping.Businnes.IServices;
using OnlineShopping.Businnes.Models.UserModel;

namespace OnlineShopping.API.Controllers;

[Route("api/[controller]")]
[ApiController]

public class UserController : ControllerBase
{
    private readonly IUserService _userService;
    public UserController(IUserService userService) => _userService = userService;

    [HttpPost("create")]
    public async Task<IActionResult> CreateUser(CreateUserModel userModel)
    {
        return Created("", await _userService.CreateService(userModel));
    }

    [HttpGet("get-all")]
    public async Task<IActionResult> GetAllUsers()
    {
        var result = await _userService.GetAllService();
        return Ok(result);
    }

    [HttpGet("get-by-id")]
    public async Task<IActionResult> GetUserById(int id)
    {
        var getUser = await _userService.GetByIdService(id);
        return Ok(getUser);
    }

    [HttpDelete("delete")]
    public async Task<IActionResult> DeleteUser(int id)
    {
        await _userService.DeleteService(id);
        return Ok();
    }

    [HttpPut("update")]
    public async Task<IActionResult> UpdateUser(int id, UpdateUserModel update)
    {
        await _userService.UpdateService(id, update);
        return Ok(update);
    }
}
