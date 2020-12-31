using GS.Domain;

namespace GMall.Types
{
    public class Money : ValueObject
    {
        public decimal Value { get; private set; }
        public Money(decimal aValue) => Value = aValue;
        /// <summary>
        /// 加法
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public Money Plus(Money value) => new Money(Value + value.Value);
        /// <summary>
        /// 减法
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public Money Minus(Money value) => new Money(Value - value.Value);
    }
}
