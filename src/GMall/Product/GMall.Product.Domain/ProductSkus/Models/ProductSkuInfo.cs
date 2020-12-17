using GMall.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace GMall.Product.Domain.ProductSkus
{
    public class ProductSkuInfo
    {
        public ProductId ProductId { get; private set; }
        public SpecificationId SpecificationId { get; private set; }
        public Money UnitPrice { get; private set; }
        public ProductSkuInfo(ProductId aProductId, SpecificationId aSpecificationId, Money aUnitPrice)  
        {
            ProductId = aProductId;
            SpecificationId = aSpecificationId;
            UnitPrice = aUnitPrice; 
        }
    }
}
