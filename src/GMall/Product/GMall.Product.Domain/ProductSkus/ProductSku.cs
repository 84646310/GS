using GMall.Types;
using GS.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace GMall.Product.Domain.ProductSkus
{
    public class ProductSku : AggregateRoot<ProductSkuId>
    {
        public ProductId ProductId { get; private set; }
        public SpecificationId SpecificationId { get; private set; }
        public Money Price { get; private set; }
        public Inventory Inventory { get; private set; }
        public ProductSku(ProductSkuId aId, ProductId aProductId, SpecificationId aSpecificationId, Money aPrice, Inventory aInventory) : base(aId)
        {
            ProductId = aProductId;
            SpecificationId = aSpecificationId;
            Price = aPrice;
            Inventory = aInventory;
        }
    }
}
