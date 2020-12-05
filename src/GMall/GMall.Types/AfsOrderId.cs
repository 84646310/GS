namespace GMall.Types
{
    public class AfsOrderId
    {
        public long Value { get; private set; }
        public AfsOrderId(long aValue)
        {
            Value = aValue;
        }
    }
}
