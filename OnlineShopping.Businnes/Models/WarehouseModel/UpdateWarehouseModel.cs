using System.Text.Json.Serialization;

namespace OnlineShopping.Businnes.Models.WarehouseModel;

public class UpdateWarehouseModel
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}
