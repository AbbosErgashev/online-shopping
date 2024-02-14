using OnlineShopping.Businnes.Models.UserModel;
namespace OnlineShopping.Businnes.IServices;

public interface IUserService
{
    Task<IEnumerable<ReadUserModel>> GetAllService();
    Task<ReadUserModel> GetByIdService(int id);
    Task<ReadUserModel> CreateService(CreateUserModel user);
    Task UpdateService(int id, UpdateUserModel user);
    Task DeleteService(int id);
}
