using GMall.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace GMall.Product.Domain.Products
{
    public class PropertyInfo
    {
        public PropertyId PropertyId { get; private set; }
        public PropertyValueId PropertyValueId { get; private set; }
        public string PropertyValue { get; private set; }
        public PropertyInfo(PropertyId aPropertyId, PropertyValueId aPropertyValueId, string aPropertyValue)
        {
            PropertyId = aPropertyId;
            PropertyValueId = aPropertyValueId;
            PropertyValue = aPropertyValue;
        }
    }
}
