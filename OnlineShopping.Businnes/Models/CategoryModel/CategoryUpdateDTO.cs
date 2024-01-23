using System.Text.Json.Serialization;

namespace OnlineShopping.Businnes.Models.CategoryModel;

/// <summary>
/// Category UpdateUserRepository DTO
/// </summary>
public class CategoryUpdateDTO
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}
