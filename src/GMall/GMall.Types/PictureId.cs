using System;
using System.Collections.Generic;
using System.Text;

namespace GMall.Types
{
    public class PictureId
    {
        public long Value { get; private set; }
        public PictureId(long aValue)
        {
            Value = aValue;
        }
    }
}
