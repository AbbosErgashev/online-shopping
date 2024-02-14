using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace OnlineShopping.Businnes.Models.WarehouseProductModel;

public class ReadWarehouseProductModel
{
    [JsonProperty("id")]
    public int Id { get; set; }

    [JsonPropertyName("count")]
    public ulong ProductCount { get; set; }

    [JsonPropertyName("price")]
    public decimal Price { get; set; }
}
