using GS.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace GMall.Types
{
    public class PictureId : LongGuid
    {
        public PictureId()
        {

        }
        public PictureId(long aValue) : base(aValue)
        { 
        }
    }
}
