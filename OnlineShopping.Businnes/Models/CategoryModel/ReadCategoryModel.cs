using System.Text.Json.Serialization;

namespace OnlineShopping.Businnes.Models.CategoryModel;

public class ReadCategoryModel
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }
}
