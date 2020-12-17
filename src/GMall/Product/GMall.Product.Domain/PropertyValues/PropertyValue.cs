using GMall.Types;
using GS.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace GMall.Product.Domain.PropertyValues
{
    public class PropertyValue : AggregateRoot<PropertyValueId>
    {
        public string Name { get; private set; }
        public int Sort { get; private set; }
        public PropertyValue(PropertyValueId aId, string aName, int aSort) : base(aId)
        {
            Name = aName;
            Sort = aSort;
        }
        public void Update(string aName)
        {
            Name = aName;
        }
        public void UpdateSort(int aSort)
        {
            Sort = aSort;
        }
    }
}
