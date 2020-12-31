using System;
using System.Collections.Generic;
using System.Text;

namespace GMall.EFCore
{
    public abstract class BaseDO<TKey>
    {
        public virtual TKey Id { get; set; }
    }
}
