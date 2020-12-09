using GMall.Types;
using GS.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace GMall.Product.Domain.Propertys
{
    public class Property:AggregateRoot<PropertyId>
    {
        public string Name { get; private set; }
        public Property(PropertyId aId,string aName):base(aId)
        {
            Name = aName;
        }
    }
}
