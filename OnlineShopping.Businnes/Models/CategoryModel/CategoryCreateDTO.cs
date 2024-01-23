using System.Text.Json.Serialization;

namespace OnlineShopping.Businnes.Models.CategoryModel;

/// <summary>
/// Category CreateCategoryRepository DTO
/// </summary>
public class CategoryCreateDTO
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}
