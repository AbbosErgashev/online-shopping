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
        this.user = user;
        this.mapper = mapper;
    }

    [HttpPost]
    public async Task<IActionResult> Create(UserCreateDTO userModel)
    {
        var createUser = mapper.Map<User>(userModel);

        await user.Create(createUser);

        await user.SaveChangesAsync();

        return Created("", createUser);
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var getAllUsers = await user.GetAll();

        if (getAllUsers is null) 
            return NoContent();

        return Ok(mapper.Map<IEnumerable<UserReadDTO>>(getAllUsers));
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var getUserById = await user.GetById(id);

        if (getUserById is null) 
            return NotFound();

        await user.SaveChangesAsync();

        return Ok(mapper.Map<UserReadDTO>(getUserById));
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var deleteUserById = await user.GetById(id);

        if (deleteUserById is null) 
            return NoContent();

        user.Delete(deleteUserById);

        await user.SaveChangesAsync();

        return NoContent();
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateUser(int id, UserUpdateDTO update)
    {
        var getById = await user.GetById(id);

        if (getById is null) return NotFound();

        mapper.Map(update, getById);

        await user.Update(getById);

        await user.SaveChangesAsync();

        return NoContent();
    }
}
