using GS.Domain;

namespace GMall.Types
{
    public class OrderId : LongGuid
    {
        public OrderId()
        {

        }
        public OrderId(long aValue) : base(aValue)
        { 
        }
    }
}
