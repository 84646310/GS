using GS.Domain;
using System;

namespace GMall.Types
{
    public class SpecificationId : ValueObject
    {
        public Guid Value { get; private set; }
        public SpecificationId() => Value = Guid.NewGuid();
        public SpecificationId(Guid aValue)
        {
            if (aValue.Equals(Guid.Empty))
                throw new ArgumentException($"{GetType().Name}不能为空");
            Value = aValue;
        }
    }
}
