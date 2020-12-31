using GMall.Types;
using GS.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace GMall.Product.Domain.Products
{
    public class PropertyInfo : Entity<int>
    {
        public PropertyId PropertyId { get; private set; }
        public PropertyValueId PropertyValueId { get; private set; }
        public string PropertyValue { get; private set; }
        public PropertyInfo(
            int aId, PropertyId aPropertyId, PropertyValueId aPropertyValueId, string aPropertyValue) : base(aId)
        {
            PropertyId = aPropertyId;
            PropertyValueId = aPropertyValueId;
            PropertyValue = aPropertyValue;
        }
        public void Update(PropertyId aPropertyId, PropertyValueId aPropertyValueId, string aPropertyValue)
        {
            PropertyId = aPropertyId;
            PropertyValueId = aPropertyValueId;
            PropertyValue = aPropertyValue;
        }
    }
}
