using System;
using System.Collections.Generic;
using System.Text;

namespace GMall.Product.Domain.ProductSkus
{
    public class Inventory
    {
        /// <summary>
        /// 可销售库存
        /// </summary>
        public int Sellable { get; private set; }
        /// <summary>
        /// 可用库存
        /// </summary>
        public int Available { get; private set; }

    }
}
