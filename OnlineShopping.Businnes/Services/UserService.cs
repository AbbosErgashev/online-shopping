using AutoMapper;
using OnlineShopping.Businnes.IServices;
using OnlineShopping.Businnes.Models.UserModel;
using OnlineShopping.Infrastructure.Entities;
using OnlineShopping.Infrastructure.IRepositories;

namespace OnlineShopping.Businnes.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;

    public UserService(IUserRepository userRepository, IMapper mapper)
    {
        _userRepository = userRepository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<UserReadModel>> GetAllUserService()
    {
        var getAll = await _userRepository.GetAllRepository();

        if (getAll is null)
            throw new ArgumentNullException(nameof(getAll));

        var mapped = _mapper.Map<IEnumerable<UserReadModel>>(getAll);

        return mapped;
    }

    public async Task<UserReadModel> GetByIdUserService(int id)
    {
        var getUserById = await _userRepository.GetByIdRepository(id);

        if (getUserById is null)
            throw new ArgumentNullException(nameof(getUserById));

        var getByIdMapped = _mapper.Map<UserReadModel>(getUserById);

        return getByIdMapped;
    }

    public async Task CreateUserService(UserCreateModel userDto)
    {
        var createUser = _mapper.Map<User>(userDto);

        await _userRepository.CreateRepository(createUser);

        await _userRepository.SaveChangesAsyncUser();
    }

    public async Task DeleteUserService(int userid)
    {
        var getUserById = await _userRepository.GetByIdRepository(userid);

        if (getUserById is null)
            throw new ArgumentNullException(nameof(getUserById));

        _userRepository.DeleteRepository(getUserById);

        await _userRepository.SaveChangesAsyncUser();
    }

    public async Task UpdateUserService(int Id, UserUpdateModel updateModel)
    {
        var getUserByid = await _userRepository.GetByIdRepository(Id);

        if (getUserByid is null)
            throw new ArgumentNullException(nameof(getUserByid));

        _mapper.Map(updateModel, getUserByid);

        await _userRepository.UpdateRepository(getUserByid);

        await _userRepository.SaveChangesAsyncUser();
    }
}
