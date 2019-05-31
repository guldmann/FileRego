using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileRego.Rules
{
    public abstract class BaseRule : IEquatable<BaseRule>, ICloneable
    {
        public bool Active { get; set; } = true;
        public Guid Index { get; private set; }
        public RuleType Type { get; set; }

        public string Text { get; set; }

        private BaseRule()
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
            if (ReferenceEquals(this, other)) return true;
            return Equals(Type, other.Type) && Active == other.Active && string.Equals(Text, other.Text);

        }
        public override bool Equals(object obj)
        {

            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((BaseRule)obj);
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
