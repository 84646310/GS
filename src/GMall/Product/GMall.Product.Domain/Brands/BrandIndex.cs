using GMall.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace GMall.Product.Domain.Brands
{
    public class BrandIndex
    {
        public BrandId UniqueId { get; private set; }
        public string Name { get; private set; }
        public BrandIndex(BrandId aBrandId,string aName)
        {
            UniqueId = aBrandId;
            Name = aName;
        }
    }
}
