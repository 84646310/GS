using GMall.Types;
using GS.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace GMall.Product.Domain.Brands
{
    public class Brand : AggregateRoot<BrandId>
    {
        public string Name { get; private set; }
        public Logo Logo { get; private set; }
        public Brand(BrandId aId, string aName, Logo aLogo) : base(aId)
        {
            Name = aName;
            Logo = aLogo;
        }
    }
}
