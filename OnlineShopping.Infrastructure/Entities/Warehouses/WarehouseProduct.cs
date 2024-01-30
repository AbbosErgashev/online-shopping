using System.ComponentModel.DataAnnotations;

namespace OnlineShopping.Infrastructure.Entities.Warehouses;

public class WarehouseProduct
{
    [Key]
    public int WarehouseProductId { get; set; }
    public ulong ProductCount { get; set; }
    public decimal Price { get; set; }
}
