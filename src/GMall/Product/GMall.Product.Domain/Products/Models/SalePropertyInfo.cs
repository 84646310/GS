using GMall.Types;
using GS.Domain;
using System.Collections.Generic;

namespace GMall.Product.Domain.Products
{
    public class SalePropertyInfo : Entity<int>
    {
        public PropertyId PropertyId { get; private set; }
        public ICollection<PropertyValueId> PropertyValueIds { get; private set; }
        public SalePropertyInfo(
            int aUniqueId, PropertyId aPropertyId, ICollection<PropertyValueId> aPropertyValueIds) : base(aUniqueId)
        {
            PropertyId = aPropertyId;
            PropertyValueIds = aPropertyValueIds;
        }
    }
}
