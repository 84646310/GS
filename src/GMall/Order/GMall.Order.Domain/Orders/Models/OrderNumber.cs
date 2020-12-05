using System;
using System.Collections.Generic;
using System.Text;

namespace GMall.Order.Domain.Orders
{
    public class OrderNumber
    {
        public string Value { get; private set; }
        public OrderNumber(string aValue)
        {
            Value = aValue;
        }
    }
}
