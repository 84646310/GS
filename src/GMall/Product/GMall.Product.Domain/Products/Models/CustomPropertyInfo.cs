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
        public CustomPropertyInfo(int aUniqueId, PropertyId aPropertyId, string aPropertyValue) : base(aUniqueId)
        {
            PropertyId = aPropertyId;
            PropertyValue = aPropertyValue;
        }
    }
}
