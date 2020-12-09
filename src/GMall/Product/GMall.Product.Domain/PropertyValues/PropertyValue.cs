using GMall.Types;
using GS.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace GMall.Product.Domain.PropertyValues
{
    public class PropertyValue:AggregateRoot<PropertyValueId>
    {
        public string Name { get; private set; }
        public PropertyValue(PropertyValueId aId,string aName):base(aId)
        {
            Name = aName;
        }
    }
}
