using System;
using System.Collections.Generic;
using System.Text;

namespace GMall.Types
{
    public class Money
    {
        public decimal Value { get; private set; }
        public Money(decimal aValue)
        {
            Value = aValue;
        }
        /// <summary>
        /// 加法
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public Money Plus(Money value)
        {
            return new Money(Value + value.Value);
        }
        /// <summary>
        /// 减法
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public Money Minus(Money value)
        {
            return new Money(Value - value.Value);
        }
    }
}
