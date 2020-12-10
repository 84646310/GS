using GS.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace GMall.Types
{
    public class BrandId : LongGuid
    {
        public BrandId()
        { 
        }
        public BrandId(long aValue) : base(aValue)
        {
        }
    }
}
