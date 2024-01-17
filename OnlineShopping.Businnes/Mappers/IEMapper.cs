using AutoMapper;
using OnlineShopping.Businnes.Models.UserModel;
using OnlineShopping.Infrastructure.Entities;

namespace OnlineShopping.Businnes.Mappers;

public class IEMapper : Profile
{
    public IEMapper()
    {
        CreateMap<User, CreateUserModel>().ReverseMap();
        CreateMap<User, UpdateUserModel>().ReverseMap();
        CreateMap<User, ReadUserModel>().ReverseMap();
    }
}
