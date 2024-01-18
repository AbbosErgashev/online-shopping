using OnlineShopping.Infrastructure.Entities.Base;

namespace OnlineShopping.Infrastructure.Entites.Base;

public class Entity : EntityBase<int> 
{
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set;} = DateTime.UtcNow;
}
