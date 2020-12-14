using GMall.Order.Domain.Orders;
using GMall.Order.Domain.Orders.Repositories;
using GMall.Types;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GMall.Order.Infrastructure
{
    public class OrderRepository : IOrderRepository
    {
        public Task<Domain.Orders.Order> GetByIdAsync(OrderId aAggregateRootId)
        {
            throw new System.NotImplementedException();
        }

        public Task<Domain.Orders.Order> GetByOrderNumberAsync(OrderNumber aOrderNumber)
        {
            throw new System.NotImplementedException();
        }

        public Task<OrderId> NextIdAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task SaveAsync(Domain.Orders.Order aAggregateRoot)
        {
            throw new System.NotImplementedException();
        }

        public Task SaveAsync(IList<Domain.Orders.Order> aAggregateRoot)
        {
            throw new System.NotImplementedException();
        }
    }
}
