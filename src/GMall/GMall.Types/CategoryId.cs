using GS.Domain;
using System;

namespace GMall.Types
{
    public class CategoryId : ValueObject
    {
        public Guid Value { get; private set; }
        public CategoryId() => Value = Guid.NewGuid();
        public CategoryId(Guid aValue)
        {
            if (aValue.Equals(Guid.Empty))
                throw new ArgumentException($"{GetType().Name}不能为空");
            Value = aValue;
        }
    }
}
