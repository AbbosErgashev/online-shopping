using System.ComponentModel.DataAnnotations;

namespace OnlineShopping.Infrastructure.Entities;

public class Category
{
    [Key]
    public int Id {  get; set; }
    public required string Name { get; set; }
}
