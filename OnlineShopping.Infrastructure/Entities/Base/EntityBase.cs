namespace OnlineShopping.Infrastructure.Entities.Base;

public abstract class EntityBase<TId> : IEntityBase<TId>
{
    public virtual TId Id { get; set; }

    private int? _cachedHashCode;

    public bool IsTransient()
    {
        return Id.Equals(default(TId));
    }

    public override bool Equals(object? obj)
    {
        if (obj is null || !(obj is IEntityBase<TId>)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (GetType() != obj.GetType()) return false;

        var item = (EntityBase<TId>)obj;

        if (item.IsTransient() || IsTransient()) return false;
        else return item.Id.Equals(Id);
    }

    public override int GetHashCode()
    {
        if (!IsTransient())
        {
            if (!_cachedHashCode.HasValue) _cachedHashCode = Id.GetHashCode() ^ 31;

            return _cachedHashCode.Value;
        }
        else
        {
            return base.GetHashCode();
        }
    }

    public static bool operator ==(EntityBase<TId> left, EntityBase<TId> right)
    {
        if (ReferenceEquals(left, null) && ReferenceEquals(right, null))
            return true;

        if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
            return false;

        return left.Equals(right);
    }

    public static bool operator !=(EntityBase<TId> left, EntityBase<TId> right) => !(left == right);
}
