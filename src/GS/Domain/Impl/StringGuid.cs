using System;
using System.Collections.Generic;
using System.Text;

namespace GS.Domain
{
    public abstract class StringGuid : IUniqueId
    {
        protected string Value { get; set; }
        public StringGuid()
        {
            Value = CreateGuid();
        }
        public StringGuid(string aValue)
        { 
            Value = aValue;
        }
        private string CreateGuid()
        {
            long i = 1;
            foreach (byte b in Guid.NewGuid().ToByteArray())
            {
                i *= ((int)b + 1);
            }
            return string.Format("{0:x}", i - DateTime.Now.Ticks);
        }
    }
}
