using System.Text.Json.Serialization;

namespace OnlineShopping.Businnes.Models.CategoryModel;

public class UpdateCategoryModel
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}
