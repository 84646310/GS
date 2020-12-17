using System;
using System.Collections.Generic;
using System.Text;

namespace GMall.EFCore.Models
{
    public class ProductCustomPropertyDO
    {
        public long ProductId { get; set; }
        public long PropertyId { get; set; }
        public string PropertyValue { get; set; }
    }
}
