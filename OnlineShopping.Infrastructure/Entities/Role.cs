namespace OnlineShopping.Infrastructure.Entities;

public class Role
{
    public int RoleId { get; set; }
    public required string Name { get; set; }
    public required string Description { get; set; }
    public List<User?>? Users { get; set; }
}
