using GMall.Types;
using GS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GMall.Product.Domain.Categories
{
    public class PropertyInfo : Entity<int>
    {
        public PropertyId PropertyId { get; private set; }
        public ICollection<PropertyValueId> PropertyValueIds { get; private set; }
        public PropertyInfo(int aId, PropertyId aPropertyId, ICollection<PropertyValueId> aPropertyValueIdCollection) : base(aId)
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
