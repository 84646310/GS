using GMall.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace GMall.Product.Domain.Products
{
    public class CustomProperty
    {
        public PropertyId PropertyId { get; private set; }
        public string PropertyValue { get; private set; }
        public CustomProperty(PropertyId aPropertyId, string aPropertyValue)
        {
            PropertyId = aPropertyId;
            PropertyValue = aPropertyValue;
        }
    }
}
