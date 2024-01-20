using System.Text.Json.Serialization;

namespace OnlineShopping.Businnes.Models.CategoryModel;

/// <summary>
/// Category Read DTO
/// </summary>
public class CategoryReadDTO
{
    public int CategoryId { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }
}
