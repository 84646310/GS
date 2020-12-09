using System;
using System.Collections.Generic;
using System.Text;

namespace GMall.Types
{
    public class BrandId
    {
        public long Value { get; private set; }
        public BrandId(long aValue)
        {
            Value = aValue;
        }
    }
}
