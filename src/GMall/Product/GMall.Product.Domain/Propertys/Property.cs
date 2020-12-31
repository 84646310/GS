using GMall.Types;
using GS.Domain;
using System;

namespace GMall.Product.Domain.Propertys
{
    public class Property : AggregateRoot<PropertyId>
    {
        public string Name { get; private set; }
        public int Sort { get; private set; } 
        public Property(PropertyId aId, string aName, int aSort) : base(aId)
        {
            if (string.IsNullOrWhiteSpace(aName))
                throw new ArgumentException("属性名称不能为空");
            Name = aName;
            Sort = aSort; 
        }
        public void Update(string aName)
        {
            if (string.IsNullOrWhiteSpace(aName))
                throw new ArgumentException("属性名称不能为空");
            Name = aName;
        }
        public void UpdateSort(int aSort)
        {
            Sort = aSort;
        }
        
    }
}
