using System;
using System.Collections.Generic;
using System.Text;

namespace GMall.EFCore.Models
{
    public class PropertyValueDO
    {
        public long Id { get; set; }
        public long PropertyId { get; set; }
        public string Name { get; set; }
        public int Sort { get; set; }
    }
}
