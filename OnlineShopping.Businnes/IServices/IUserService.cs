using OnlineShopping.Businnes.Models.UserModel;
namespace OnlineShopping.Businnes.IServices;

public interface IUserService
{
    Task<IEnumerable<ReadUserModel>> GetAllUserService();
    Task<ReadUserModel> GetByIdUserService(int id);
    Task<ReadUserModel> CreateUserService(CreateUserModel user);
    Task UpdateUserService(int id, UserUpdateModel user);
    Task DeleteUserService(int id);
}
