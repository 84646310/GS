using GMall.Types;
using GS.Domain;

namespace GMall.Order.Domain.AfsOrders
{
    public class AfsOrder : AggregateRoot<AfsOrderId>
    {
        public AfsOrder(AfsOrderId aAfsOrderId) : base(aAfsOrderId)
        {

        }
    }
}
