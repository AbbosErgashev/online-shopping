using OnlineShopping.Businnes.Models.UserModel;
namespace OnlineShopping.Businnes.IServices;

public interface IUserService
{
    Task<IEnumerable<UserReadDTO>> GetAllUsers();
    Task<UserReadDTO> GetUserById(int id);
    Task CreateUserService(UserCreateDTO user);
    Task UpdateUserService(int id, UserUpdateDTO user);
    Task DeleteUserService(int id);
}
