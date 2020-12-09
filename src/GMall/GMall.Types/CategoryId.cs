using System;
using System.Collections.Generic;
using System.Text;

namespace GMall.Types
{
    public class CategoryId
    {
        public long Value { get; private set; }
        public CategoryId(long aValue)
        {
            Value = aValue;
        }
    }
}
