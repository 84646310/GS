using GS.Domain;
using System;

namespace GMall.Types
{
    public class PropertyId : ValueObject
    {
        public Guid Value { get; private set; }
        public PropertyId() => Value = Guid.NewGuid();
        public PropertyId(Guid aValue)
        {
            if (aValue.Equals(Guid.Empty))
                throw new ArgumentException($"{GetType().Name}不能为空");
            Value = aValue;
        }
    }
}
