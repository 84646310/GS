using GMall.Types;
using GS.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace GMall.Product.Domain.ProductSkus
{
    public class ProductSku : AggregateRoot<ProductSkuId>
    {
        public ProductSkuInfo Info { get; private set; }
        public Inventory Inventory { get; private set; }
        public ProductSku(ProductSkuId aId, ProductSkuInfo aInfo, Inventory aInventory) : base(aId)
        {
            Info = aInfo;
            Inventory = aInventory;
        }
    }
}
