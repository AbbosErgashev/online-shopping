using System.Text.Json.Serialization;

namespace OnlineShopping.Businnes.Models.WarehouseModel;

public class CreateWarehouseModel
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}
