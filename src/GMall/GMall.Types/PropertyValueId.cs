using System;
using System.Collections.Generic;
using System.Text;

namespace GMall.Types
{
    public class PropertyValueId
    {
        public long Value { get; private set; }
        public PropertyValueId(long aValue)
        {
            Value = aValue;
        }
    }
}
