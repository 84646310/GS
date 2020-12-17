using System;
using System.Collections.Generic;
using System.Text;

namespace GMall.EFCore.Models
{
    public class ProductSpecificationPropertyDO
    {
        public long ProductId { get; set; }
        public long SpecificationId { get; set; }
        public long PropertyId { get; set; }
        public string Property { get; set; }
        public long PropertyValueId { get; set; }
        public string PropertyValue { get; set; }
    }
}
