using AutoMapper;
using OnlineShopping.Businnes.Models.UserModel;
using OnlineShopping.Infrastructure.Entities;

namespace OnlineShopping.Businnes.Mappers;

public class UserMapper : Profile
{
    public UserMapper()
    {
        CreateMap<User, UserCreateModel>().ReverseMap();
        CreateMap<User, UserUpdateModel>().ReverseMap();
        CreateMap<User, UserReadModel>().ReverseMap();
    }
}
