using GMall.Types;
using GS.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace GMall.Product.Domain.Products
{
    public class CustomPropertyInfo : Entity<int>
    {
        public PropertyId PropertyId { get; private set; }
        public string PropertyValue { get; private set; }
        public CustomPropertyInfo(int aId, PropertyId aPropertyId, string aPropertyValue) : base(aId)
        {
            PropertyId = aPropertyId;
            PropertyValue = aPropertyValue;
        }
        public void Update( PropertyId aPropertyId, string aPropertyValue) 
        {
            PropertyId = aPropertyId;
            PropertyValue = aPropertyValue;
        }
    }
}
