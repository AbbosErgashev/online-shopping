using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OnlineShopping.Businnes.Models.UserModel;
using OnlineShopping.Infrastructure.Entities;
using OnlineShopping.Infrastructure.IRepositories;

namespace OnlineShopping.API.Controllers;

[Route("api/[controller]")]
[ApiController]

public class UserController : ControllerBase
{
    private readonly IMapper mapper;
    private readonly IUserRepository user;

    public UserController(IMapper mapper, IUserRepository user)
    {
        this.mapper = mapper;
        this.user = user;
    }

    [HttpPost]
    public async Task<IActionResult> CreateUser(CreateUserModel userModel)
    {
        var createUser = mapper.Map<User>(userModel);

        await user.CreateUser(createUser);

        await user.SaveChangesAsync();

        return Created("", createUser);
    }

    [HttpGet]
    public async Task<IActionResult> GetAllUsers()
    {
        var getAllUsers = await user.GetAllUsers();

        if (getAllUsers is null) return NoContent();

        return Ok(mapper.Map<IEnumerable<ReadUserModel>>(getAllUsers));
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetUserById(int id)
    {
        var getUserById = await user.GetUserById(id);

        if (getUserById is null) return NotFound();

        await user.SaveChangesAsync();

        return Ok(mapper.Map<ReadUserModel>(getUserById));
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteUser(int id)
    {
        var deleteUserById = await user.GetUserById(id);

        if (deleteUserById is null) return NoContent();

        user.DeleteUser(deleteUserById);

        await user.SaveChangesAsync();

        return NoContent();
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateUser(int id, UpdateUserModel model)
    {
        var getUserByIdForUpdate = await user.GetUserById(id);

        if (getUserByIdForUpdate is null) return NotFound();

        mapper.Map(model, getUserByIdForUpdate);

        await user.UpdateUser(getUserByIdForUpdate);

        await user.SaveChangesAsync();

        return NoContent();
    }
}
