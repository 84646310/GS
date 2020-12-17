using System;
using System.Collections.Generic;
using System.Text;

namespace GMall.EFCore.Models
{
    public class ProductSalePropertyValueDO
    {
        public long ProductId { get; set; }
        public long PropertyId { get; set; }
        public long PropertyValueId { get; set; }
    }
}
