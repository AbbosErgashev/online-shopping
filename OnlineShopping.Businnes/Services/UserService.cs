﻿using AutoMapper;
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

    public async Task<IEnumerable<ReadUserModel>> GetAllService()
    {
        try
        {
            var getAll = await _userRepository.GetAllRepository();
            var mapped = _mapper.Map<IEnumerable<ReadUserModel>>(getAll);
            return mapped;
        }
        catch
        {
            throw new Exception("Users not found");
        }
    }

    public async Task<ReadUserModel> GetByIdService(int id)
    {
        var getById = await _userRepository.GetByIdRepository(id);
        if (getById is null)
            throw new Exception("User not found");

        var mapped = _mapper.Map<ReadUserModel>(getById);
        return mapped;
    }

    public async Task<ReadUserModel> CreateService(CreateUserModel userDto)
    {
        try
        {
            var create = _mapper.Map<User>(userDto);
            await _userRepository.CreateRepository(create);
            var mapped = _mapper.Map<ReadUserModel>(create);
            return mapped;
        }
        catch
        {
            throw new Exception("User not created");
        }
    }

    public async Task DeleteService(int id)
    {
        try
        {
            var getUserById = await _userRepository.GetByIdRepository(id);
            await _userRepository.DeleteRepository(getUserById);
            _mapper.Map<ReadUserModel>(getUserById);
            await _userRepository.SaveChangesAsync();
        }
        catch
        {
            throw new Exception("User not found");
        }
    }

    public async Task UpdateService(int Id, UpdateUserModel updateModel)
    {
        var getUserByid = await _userRepository.GetByIdRepository(Id);
        if (getUserByid is null)
            throw new Exception("User not found");

        _mapper.Map(updateModel, getUserByid);
        await _userRepository.UpdateRepository(getUserByid);
        _mapper.Map<ReadUserModel>(getUserByid);
        await _userRepository.SaveChangesAsync();
    }
}
