using GS.Domain;
using System;

namespace GMall.Types
{
    public class ProductId : ValueObject
    {
        public Guid Value { get; private set; }
        public ProductId() => Value = Guid.NewGuid();
        public ProductId(Guid aValue)
        {
            if (aValue.Equals(Guid.Empty))
                throw new ArgumentException($"{GetType().Name}不能为空");
            Value = aValue;
        }
    }
}
