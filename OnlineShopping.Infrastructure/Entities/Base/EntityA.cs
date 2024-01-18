using OnlineShopping.Infrastructure.Entites.Base;

namespace OnlineShopping.Infrastructure.Entities.Base;

public class EntityA : Entity
{
    public int CreatedUserId { get; set; }
    private int UpdatedUserId { get; set; }
    public User CreatedUser { get; set; }
    public User UpdatedUser { get; set; }
}
