using AutoMapper;
using OnlineShopping.Businnes.Models;
using OnlineShopping.Infrastructure.Entities;

namespace OnlineShopping.Businnes.Mappers;

public class IEMapper : Profile
{
    public IEMapper()
    {
        CreateMap<User, UserModel>().ReverseMap();
    }
}
