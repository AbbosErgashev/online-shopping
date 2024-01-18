using OnlineShopping.Infrastructure.Entites.Base;

namespace OnlineShopping.Infrastructure.Entities.Base;

public class EntityPro : Entity
{
    public bool IsBasic { get; set; }
    public bool IsPro {  get; set; }
    public bool IsLLC { get; set; }
}
