using System.ComponentModel.DataAnnotations;

namespace OnlineShopping.Infrastructure.Entities;

public class Product
{
    [Key]
    public int ProductId {  get; set; }
    public int CategoryId { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }
    public required decimal Price { get; set; }
    public required string Phone { get; set; }
}
