using OnlineShopping.Infrastructure.Entites.Base;

namespace OnlineShopping.Infrastructure.Entities.Base;

public class EntityA : Entity
{
    public int CreatedUserId { get; set; }
    private int _updatedUserId { get; set; }
    public int UpdatedUserId
    {
        set => _updatedUserId = value;
        get => (_updatedUserId == 0  && this.CreatedUserId != 0) ? CreatedUserId : _updatedUserId;
    }
    public User CreatedUser { get; set; }
    public User UpdatedUser { get; set; }
}
