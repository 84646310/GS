using GMall.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace GMall.Product.Domain.Brands
{
    public class BrandIndex
    {
        public BrandId Id { get; private set; }
        public string Name { get; private set; }
        public BrandIndex(BrandId aId,string aName)
        {
            Id = aId;
            Name = aName;
        }
    }
}
