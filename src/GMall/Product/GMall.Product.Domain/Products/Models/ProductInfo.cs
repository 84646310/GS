using GMall.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace GMall.Product.Domain.Products
{
    public class ProductInfo
    {
        public string Name { get; private set; }
        public string ModelCode { get; private set; }
        public string Description { get; private set; }
        public string Introduction { get; private set; }
        public BrandId BrandId { get; private set; }
        public CategoryId CategoryId { get; private set; } 
        public ProductInfo(
            string aName,
            string aModelCode,
            string aDescription,
            string aIntroduction,
            BrandId aBrandId,
            CategoryId aCategoryId
            )
        {
            Name = aName;
            ModelCode = aModelCode;
            Description = aDescription;
            Introduction = aIntroduction;
            BrandId = aBrandId;
            CategoryId = aCategoryId;
        }
    }
}
