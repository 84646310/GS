using GS.Domain;
using System;

namespace GMall.Types
{
    public class PropertyValueId : ValueObject
    {
        public Guid Value { get; private set; }
        public PropertyValueId() => Value = Guid.NewGuid();
        public PropertyValueId(Guid aValue)
        {
            if (aValue.Equals(Guid.Empty))
                throw new ArgumentException($"{GetType().Name}不能为空");
            Value = aValue;
        }
    }
}
