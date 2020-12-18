using GMall.Types;
using GS.Domain;
using System.Collections.Generic;

namespace GMall.Product.Domain.Categories
{
    public class PropertyInfo : ValueObject
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
