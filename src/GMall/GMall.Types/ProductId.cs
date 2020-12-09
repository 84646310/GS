using System;
using System.Collections.Generic;
using System.Text;

namespace GMall.Types
{
    public class ProductId
    {
        public long Value { get; private set; }
        public ProductId(long aValue)
        {
            Value = aValue;
        }
    }
}
