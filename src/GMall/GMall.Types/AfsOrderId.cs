using GS.Domain;

namespace GMall.Types
{
    public class AfsOrderId : LongGuid
    {
        public AfsOrderId()
        {
        }
        public AfsOrderId(long aValue) : base(aValue)
        {
        }
    }
}
