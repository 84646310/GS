using GS.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace GMall.Types
{
    public class PropertyValueId : LongGuid
    {
        public PropertyValueId()
        {
        }
        public PropertyValueId(long aValue) : base(aValue)
        {
        }
    }
}
