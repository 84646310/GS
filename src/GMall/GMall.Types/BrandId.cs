using GS.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace GMall.Types
{
    public class BrandId : LongGuid
    {
        public DateTime CreateTime { get; private set; }
        public BrandId()
        {
            CreateTime = DateTime.Now;
        }
        public BrandId(long aValue,DateTime aDateTime) : base(aValue)
        {
            CreateTime = aDateTime;
        }
    }
}
