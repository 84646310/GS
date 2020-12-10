using GS.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace GMall.Types
{
    public class PropertyId : LongGuid
    {
        public PropertyId()
        {

        }
        public PropertyId(long aValue) : base(aValue)
        { 
        }
    }
}
