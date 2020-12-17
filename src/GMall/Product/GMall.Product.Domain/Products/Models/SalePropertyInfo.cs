using GMall.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace GMall.Product.Domain.Products
{
    public class SalePropertyInfo
    {
        public PropertyId PropertyId { get; private set; }
        public ICollection<PropertyValueId> PropertyValueIds { get; private set; }
        public SalePropertyInfo(PropertyId aPropertyId, ICollection<PropertyValueId> aPropertyValueIds)
        {
            PropertyId = aPropertyId;
            PropertyValueIds = aPropertyValueIds;
        }
    }
}
