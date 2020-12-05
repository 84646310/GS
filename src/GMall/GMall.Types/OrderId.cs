namespace GMall.Types
{
    public class OrderId
    {
        public long Value { get; private set; }
        public OrderId(long aValue)
        {
            Value = aValue;
        }
    }
}
