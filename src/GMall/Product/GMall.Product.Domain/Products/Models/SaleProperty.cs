using GMall.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace GMall.Product.Domain.Products
{
    public class SaleProperty
    {
        public PropertyId PropertyId { get; private set; }
        public IList<PropertyValueId> PropertyValueIds { get; private set; }
        public SaleProperty(PropertyId aPropertyId, IList<PropertyValueId> aPropertyValueIds)
        {
            PropertyId = aPropertyId;
            PropertyValueIds = aPropertyValueIds;
        }
    }
}
