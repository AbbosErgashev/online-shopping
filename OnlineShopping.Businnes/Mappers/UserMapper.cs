using AutoMapper;
using OnlineShopping.Businnes.Models.UserModel;
using OnlineShopping.Infrastructure.Entities;

namespace OnlineShopping.Businnes.Mappers;

public class UserMapper : Profile
{
    public UserMapper()
    {
        CreateMap<User, UserCreateDTO>().ReverseMap();
        CreateMap<User, UserUpdateDTO>().ReverseMap();
        CreateMap<User, UserReadDTO>().ReverseMap();
    }
}
