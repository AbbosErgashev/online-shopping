using OnlineShopping.Infrastructure.Entites.Base;

namespace OnlineShopping.Infrastructure.Entities;

public class Image : Entity
{
    public required string Name { get; set; }
    public required string Path { get; set; }
}
