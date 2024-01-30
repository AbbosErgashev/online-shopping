using System.Text.Json.Serialization;

namespace OnlineShopping.Businnes.Models.CategoryModel;

/// <summary>
/// Category UpdateRepository DTO
/// </summary>
public class CategoryUpdateModel
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}
