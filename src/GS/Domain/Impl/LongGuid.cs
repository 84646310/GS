using System;
using System.Collections.Generic;
using System.Text;

namespace GS.Domain
{
    public abstract class LongGuid : IUniqueId
    {
        public long Value { get; protected set; }
        public LongGuid()
        {
            Value = CreateGuid();
        }
        public LongGuid(long aValue)
        {
            Value = aValue;
        }
        private long CreateGuid()
        {
            byte[] buffer = Guid.NewGuid().ToByteArray();
            return BitConverter.ToInt64(buffer, 0);
        }
    }
}
