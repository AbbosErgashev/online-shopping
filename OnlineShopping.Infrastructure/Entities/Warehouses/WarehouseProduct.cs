using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineShopping.Infrastructure.Entities.Warehouses;

public class WarehouseProduct
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public ulong ProductCount { get; set; }
    public decimal Price { get; set; }
}
