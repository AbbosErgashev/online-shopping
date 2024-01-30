using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace OnlineShopping.Businnes.Models.UserModel;

public class UserCreateModel
{
    [MaxLength(32)]
    [JsonPropertyName("first_name")]
    public required string FirstName { get; set; }

    [MaxLength(32)]
    [JsonPropertyName("last_name")]
    public required string LastName { get; set; }

    [JsonPropertyName("address")]
    public required string Address { get; set; }

    [MaxLength(13)]
    [JsonPropertyName("phone_number")]
    public required string Phone { get; set; }
}
