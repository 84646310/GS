using GS.Domain;
using System;

namespace GMall.Types
{
    public class AfsOrderId : ValueObject
    {
        public Guid Value { get; private set; }
        public AfsOrderId() => Value = Guid.NewGuid();
        public AfsOrderId(Guid aValue)
        {
            if (aValue.Equals(Guid.Empty))
                throw new ArgumentException($"{GetType().Name}不能为空");
            Value = aValue;
        }
    }
}
