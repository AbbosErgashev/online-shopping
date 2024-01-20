using OnlineShopping.Infrastructure.Entites.Base;

namespace OnlineShopping.Infrastructure.Entities;

public class ProductImage : Entity
{
    public int ProductId { get; set; }
    public int ImageId { get; set; }
    public bool IsMain { get; set; }
    public Product? Product { get; set; }
    public Image? Image { get; set; }
}
