using GS.Domain;
using System;

namespace GMall.Types
{
    public class ProductSkuId : ValueObject
    {
        public Guid Value { get; private set; }
        public ProductSkuId() => Value = Guid.NewGuid();
        public ProductSkuId(Guid aValue)
        {
            if (aValue.Equals(Guid.Empty))
                throw new ArgumentException($"{GetType().Name}不能为空");
            Value = aValue;
        }
    }
}
