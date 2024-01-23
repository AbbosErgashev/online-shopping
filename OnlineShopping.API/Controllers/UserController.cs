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

    [HttpPost("create-user")]
    public async Task<IActionResult> Create(UserCreateDTO userModel)
    {
        try
        {
            await _userService.CreateUserService(userModel);
            return Ok(userModel);
        }
        catch
        {
            return BadRequest("user not created");
        }
    }

    [HttpGet("get-all")]
    public async Task<IActionResult> GetAllUsers()
    {
        try
        {
            var result = await _userService.GetAllUsers();
            return Ok(result);
        }
        catch
        {
            return BadRequest("users not found");
        }
    }

    [HttpGet("get-by-id")]
    public async Task<IActionResult> GetUserById(int id)
    {
        try
        {
            var getUser = await _userService.GetUserById(id);
            return Ok(getUser);
        }
        catch
        {
            return BadRequest("user not found");
        }
    }

    [HttpDelete("delete")]
    public async Task<IActionResult> Delete(int id)
    {
        try
        {
            await _userService.DeleteUserService(id);
            return Ok("user deleted");
        }
        catch
        {
            return BadRequest("user not found");
        }
    }

    [HttpPut("update")]
    public async Task<IActionResult> UpdateUser(int id, UserUpdateDTO update)
    {
        try
        {
            await _userService.UpdateUserService(id, update);
            return Ok(update);
        }
        catch
        {
            return BadRequest("user not found and not updated");
        }
    }
}
