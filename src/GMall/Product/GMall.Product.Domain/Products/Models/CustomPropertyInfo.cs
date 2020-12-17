using GMall.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace GMall.Product.Domain.Products
{
    public class CustomPropertyInfo
    {
        public PropertyId PropertyId { get; private set; }
        public string PropertyValue { get; private set; }
        public CustomPropertyInfo(PropertyId aPropertyId, string aPropertyValue)
        {
            PropertyId = aPropertyId;
            PropertyValue = aPropertyValue;
        }
    }
}
