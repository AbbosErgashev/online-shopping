using AutoMapper;
using OnlineShopping.Businnes.Models.WarehouseModel;
using OnlineShopping.Infrastructure.Entities.Warehouses;

namespace OnlineShopping.Businnes.Mappers;

public class WarehouseMapper : Profile
{
    public WarehouseMapper()
    {
        CreateMap<Warehouse, CreateWarehouseModel>().ReverseMap();
        CreateMap<Warehouse, ReadWarehouseModel>().ReverseMap();
        CreateMap<Warehouse, UpdateWarehouseModel>().ReverseMap();
    }
}
