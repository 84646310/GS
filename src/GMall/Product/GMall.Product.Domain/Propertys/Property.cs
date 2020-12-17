using GMall.Types;
using GS.Domain;

namespace GMall.Product.Domain.Propertys
{
    public class Property : AggregateRoot<PropertyId>
    {
        public string Name { get; private set; }
        public int Sort { get; private set; } 
        public Property(PropertyId aId, string aName, int aSort) : base(aId)
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
