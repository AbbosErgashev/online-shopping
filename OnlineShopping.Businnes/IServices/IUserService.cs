using OnlineShopping.Businnes.Models.UserModel;
namespace OnlineShopping.Businnes.IServices;

public interface IUserService
{
    Task<IEnumerable<UserReadModel>> GetAllUserService();
    Task<UserReadModel> GetByIdUserService(int id);
    Task CreateUserService(UserCreateModel user);
    Task UpdateUserService(int id, UserUpdateModel user);
    Task DeleteUserService(int id);
}
