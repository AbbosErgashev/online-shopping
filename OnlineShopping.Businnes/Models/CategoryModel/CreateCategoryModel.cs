using System.Text.Json.Serialization;

namespace OnlineShopping.Businnes.Models.CategoryModel;

public class CreateCategoryModel
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}
