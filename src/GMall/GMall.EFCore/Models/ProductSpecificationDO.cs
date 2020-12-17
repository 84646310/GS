using System;
using System.Collections.Generic;
using System.Text;

namespace GMall.EFCore.Models
{
    public class ProductSpecificationDO
    {
        public long Id { get; set; }
        public long ProductId { get; set; }
        public decimal UnitPrice { get; set; }
        public string PropertyString { get; set; }
    }
}
