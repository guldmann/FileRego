using System;

namespace FileRego.Rules
{
    public abstract class BaseRule : IEquatable<BaseRule>, ICloneable
    {
        public bool Active { get; set; } = true;
        public Guid Index { get; private set; }
        public RuleType Type { get; set; }

        public string Text { get; set; }

        public BaseRule()
        {
            if (Index == Guid.Empty)
            {
                Index = Guid.NewGuid();
            }
        }

        private void SetNewIndex() => Index = Guid.NewGuid();
        public virtual string Apply(string text) => null;

        public bool Equals(BaseRule other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (other.Index == Index) return true;
            if (other.Index != Index) return false;
            return ReferenceEquals(this, other) || (Equals(Type, other.Type)
                   && Active
                   == other.Active
                   && string.Equals(Text, other.Text));
        }

        public override bool Equals(object obj)
        {
            return !ReferenceEquals(null, obj)
                   && (ReferenceEquals(this, obj)
                   || (obj.GetType()
                   == GetType()
                   && Equals((BaseRule)obj)));
        }

        public object Clone()
        {
            var clone = (BaseRule)MemberwiseClone();
            clone.SetNewIndex();
            return clone;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                //var hashCode = (Type != null ? Type.GetHashCode() : 0);
                var hashCode = Type.GetHashCode();
                hashCode = (hashCode * 397) ^ Active.GetHashCode();
                hashCode = (hashCode * 397) ^ (Text?.GetHashCode() ?? 0);
                return hashCode;
            }
        }
    }
}
