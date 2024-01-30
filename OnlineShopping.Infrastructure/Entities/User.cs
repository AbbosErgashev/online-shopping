using System.ComponentModel.DataAnnotations;

namespace OnlineShopping.Infrastructure.Entities;

public class User
{
    [Key]
    public int Id { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required string Address { get; set; }
    public required string Phone { get; set; }
}
