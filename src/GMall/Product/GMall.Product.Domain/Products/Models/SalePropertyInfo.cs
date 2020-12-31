using GMall.Types;
using GS.Domain;
using System;
using System.Collections.Generic;

namespace GMall.Product.Domain.Products
{
    public class SalePropertyInfo : Entity<int>
    {
        public PropertyId PropertyId { get; private set; }
        public ICollection<PropertyValueId> PropertyValueIds { get; private set; }
        public SalePropertyInfo(int aId, PropertyId aPropertyId, ICollection<PropertyValueId> aPropertyValueIdCollection) : base(aId)
        {
            if (aId <= 0)
                throw new ArgumentException("Id不能小于或等于0");
            //if(aPropertyId==null)
            //    throw new ArgumentException("属性Id不能为空");
            //if (aPropertyValueIdCollection == null)
            //    throw new ArgumentException("属性值Id不能为空");

            PropertyId = aPropertyId;
            PropertyValueIds = aPropertyValueIdCollection;
        }

        public void Update(PropertyId aPropertyId, ICollection<PropertyValueId> aPropertyValueIdCollection)
        {
            PropertyId = aPropertyId;
            PropertyValueIds = aPropertyValueIdCollection;
        }
    }
}
