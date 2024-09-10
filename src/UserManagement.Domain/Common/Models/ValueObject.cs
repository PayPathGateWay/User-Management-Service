namespace UserManagement.Domain.Common.Models;

public abstract class ValueObject
{
    protected abstract IEnumerable<object> GetEqualityComponents();

    public override bool Equals(object obj)
    {
        if (obj == null || obj.GetType() != GetType())
            return false;

        var valueObject = (ValueObject)obj;

        using (var thisValues = GetEqualityComponents().GetEnumerator())
        using (var otherValues = valueObject.GetEqualityComponents().GetEnumerator())
        {
            while (thisValues.MoveNext() && otherValues.MoveNext())
            {
                if (!thisValues.Current.Equals(otherValues.Current))
                    return false;
            }

            return !thisValues.MoveNext() && !otherValues.MoveNext();
        }
    }

    public static bool operator ==(ValueObject left, ValueObject right)
    {
        if (ReferenceEquals(left, null) && ReferenceEquals(right, null))
            return true;

        if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
            return false;

        return left.Equals(right);
    }

    public static bool operator !=(ValueObject left, ValueObject right)
    {
        return !(left == right);
    }

    public override int GetHashCode()
    {
        unchecked
        {
            int hash = 17;
            foreach (var obj in GetEqualityComponents())
            {
                hash = hash * 31 + (obj == null ? 0 : obj.GetHashCode());
            }
            return hash;
        }
    }
}