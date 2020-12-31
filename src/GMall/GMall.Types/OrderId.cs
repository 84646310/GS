using GS.Domain;
using System;

namespace GMall.Types
{
    public class OrderId : ValueObject
    {
        public Guid Value { get; private set; }
        public OrderId() => Value = Guid.NewGuid();
        public OrderId(Guid aValue)
        {
            if (aValue.Equals(Guid.Empty))
                throw new ArgumentException($"{GetType().Name}不能为空");
            Value = aValue;
        }
    }
}
