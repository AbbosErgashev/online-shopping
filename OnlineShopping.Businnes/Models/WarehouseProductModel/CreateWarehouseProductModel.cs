using System.Text.Json.Serialization;

namespace OnlineShopping.Businnes.Models.WarehouseProductModel;

public class CreateWarehouseProductModel
{
    [JsonPropertyName("product-count")]
    public required ulong ProductCount { get; set; }

    [JsonPropertyName("price")]
    public required decimal Price { get; set; }
}
