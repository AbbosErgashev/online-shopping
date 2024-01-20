using OnlineShopping.Infrastructure.Entities.Base;

namespace OnlineShopping.Infrastructure.Entites.Base;

public class Entity : EntityBase<int> 
{
    public DateTime CreatedAt { get; set; }
    public DateTime _updatedAt
    {
        get => (_updatedAt == DateTime.MinValue ? CreatedAt : _updatedAt);
        set => _updatedAt = value;
    }
}
