using OnlineShopping.Infrastructure.Entites.Base;

namespace OnlineShopping.Infrastructure.Entities;

public class ProductAttribute : Entity
{
    public int ProductId { get; set; }
    public int AttributeId { get; set; }
    public required string Value {  get; set; }
    public Product? Product { get; set; }
    public Attribute? Attribute { get; set; }
}
