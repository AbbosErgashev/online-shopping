using System.ComponentModel.DataAnnotations;

namespace OnlineShopping.Infrastructure.Entities;

public class Category
{
    [Key]
    public int CategoryId {  get; set; }
    public required string Name { get; set; }
}
