using AutoMapper;
using OnlineShopping.Businnes.Models.CategoryModel;
using OnlineShopping.Infrastructure.Entities;

namespace OnlineShopping.Businnes.Mappers;

public class CategoryMapper : Profile
{
    public CategoryMapper()
    {
        CreateMap<Category, CreateCategoryModel>().ReverseMap();
        CreateMap<Category, UpdateCategoryModel>().ReverseMap();
        CreateMap<Category, ReadCategoryModel>().ReverseMap();
    }
}
