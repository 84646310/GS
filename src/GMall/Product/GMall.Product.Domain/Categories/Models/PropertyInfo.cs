using GMall.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace GMall.Product.Domain.Categories
{
    public class PropertyInfo
    {
        public PropertyId PropertyId { get; private set; }
        public ICollection<PropertyValueId> PropertyValueIds { get; private set; }
        public PropertyInfo(PropertyId aPropertyId, ICollection<PropertyValueId> aPropertyValueIds)
        {
            PropertyId = aPropertyId;
            PropertyValueIds = aPropertyValueIds;
        }
    }
}
