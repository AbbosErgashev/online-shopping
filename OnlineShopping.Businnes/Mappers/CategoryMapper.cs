using AutoMapper;
using OnlineShopping.Businnes.Models.CategoryModel;
using OnlineShopping.Infrastructure.Entities;

namespace OnlineShopping.Businnes.Mappers;

public class CategoryMapper : Profile
{
    public CategoryMapper()
    {
        CreateMap<Category, CategoryCreateDTO>().ReverseMap();
        CreateMap<Category, CategoryUpdateDTO>().ReverseMap();
        CreateMap<Category, CategoryReadDTO>().ReverseMap();
    }
}
