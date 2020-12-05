using GMall.Types;
using GS.Domain;

namespace GMall.Order.Domain.Orders
{
    public class Order : AggregateRoot<OrderId>
    {
        public OrderNumber OrderNumber { get; private set; }
        public Order(OrderId aId, OrderNumber aOrderNumber) : base(aId)
        {
            OrderNumber = aOrderNumber;
        }
    }
}
