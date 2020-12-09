using System;
using System.Collections.Generic;
using System.Text;

namespace GMall.Types
{
    public class PropertyId
    {
        public long Value { get; private set; }
        public PropertyId(long aValue)
        {
            Value = aValue;
        }
    }
}
