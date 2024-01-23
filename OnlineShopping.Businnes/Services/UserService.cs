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

    public async Task<IEnumerable<UserReadDTO>> GetAllUsers()
    {
        var getAllUser = await _userRepository.GetAllUsers();

        if (getAllUser is null)
            throw new ArgumentNullException(nameof(getAllUser));

        var getMapped = _mapper.Map<IEnumerable<UserReadDTO>>(getAllUser);

        return getMapped;
    }

    public async Task<UserReadDTO> GetUserById(int id)
    {
        var getUserById = await _userRepository.GetUserById(id);

        if (getUserById is null)
            throw new ArgumentNullException(nameof(getUserById));

        var getByIdMapped = _mapper.Map<UserReadDTO>(getUserById);

        return getByIdMapped;
    }

    public async Task CreateUserService(UserCreateDTO userDto)
    {
        var createUser = _mapper.Map<User>(userDto);

        await _userRepository.CreateUserRepository(createUser);

        await _userRepository.SaveChangesAsync();
    }

    public async Task DeleteUserService(int userid)
    {
        var getUserById = await _userRepository.GetUserById(userid);

        if (getUserById is null)
            throw new ArgumentNullException(nameof(getUserById));

        _userRepository.DeleteUserRepository(getUserById);

        await _userRepository.SaveChangesAsync();
    }

    public async Task UpdateUserService(int updateId, UserUpdateDTO userUpdateDTO)
    {
        var getUserByid = await _userRepository.GetUserById(updateId);

        if (getUserByid is null)
            throw new ArgumentNullException(nameof(getUserByid));

        _mapper.Map(userUpdateDTO, getUserByid);

        await _userRepository.UpdateUserRepository(getUserByid);

        await _userRepository.SaveChangesAsync();
    }
}
