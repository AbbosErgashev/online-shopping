using OnlineShopping.Infrastructure.Entites.Base;

namespace OnlineShopping.Infrastructure.Entities;

public class Comment : Entity
{
    public string? Content { get; set; }
    public int? ProductId { get; set; }
    public int? UserId { get; set; }
    public Product? Product { get; set; }
    public User? User { get; set; }
}
