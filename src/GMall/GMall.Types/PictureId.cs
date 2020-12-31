using GS.Domain;
using System;

namespace GMall.Types
{
    public class PictureId : ValueObject
    {
        public Guid Value { get; private set; }
        public PictureId() => Value = Guid.NewGuid();
        public PictureId(Guid aValue)
        {
            if (aValue.Equals(Guid.Empty))
                throw new ArgumentException($"{GetType().Name}不能为空");
            Value = aValue;
        }
    }
}
