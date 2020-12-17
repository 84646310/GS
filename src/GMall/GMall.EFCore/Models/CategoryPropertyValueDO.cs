using System;
using System.Collections.Generic;
using System.Text;

namespace GMall.EFCore.Models
{
    public class CategoryPropertyValueDO
    {
        public long CategoryId { get; set; }
        public long PropertyId { get; set; }
        public long PropertyValueId { get; set; }
    }
}
