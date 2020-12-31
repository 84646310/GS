using GS.Domain;
using System;

namespace GMall.Types
{
    public class BrandId : ValueObject
    {
        public Guid Value { get; private set; }
        public BrandId() => Value = Guid.NewGuid();
        public BrandId(Guid aValue)
        {
            if (aValue.Equals(Guid.Empty))
                throw new ArgumentException("Id不能为空");
            Value = aValue;
        }
    }
}
