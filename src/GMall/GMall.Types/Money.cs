using System;
using System.Collections.Generic;
using System.Text;

namespace GMall.Types
{
    public class Money
    {
        public decimal Value { get; private set; }
        public Money(decimal aValue)
        {
            Value = aValue;
        }
    }
}
