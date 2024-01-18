namespace OnlineShopping.Infrastructure.Entities.Base;

public interface IEntityBase<TId>
{
    TId Id { get; set; }
}
