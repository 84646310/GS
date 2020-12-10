using GS.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace GMall.Types
{
    public class CategoryId : LongGuid
    {
        public CategoryId()
        {

        }
        public CategoryId(long aValue):base(aValue)
        { 
        }
    }
}
