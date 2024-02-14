using AutoMapper;
using OnlineShopping.Businnes.Models.WarehouseProductModel;
using OnlineShopping.Infrastructure.Entities.Warehouses;

namespace OnlineShopping.Businnes.Mappers;

public class WarehouseProductModel : Profile
{
    public WarehouseProductModel()
    {
        CreateMap<WarehouseProduct, CreateWarehouseProductModel>().ReverseMap();
        CreateMap<WarehouseProduct, ReadWarehouseProductModel>().ReverseMap();
        CreateMap<WarehouseProduct, UpdateWarehouseProductModel>().ReverseMap();
    }
}
