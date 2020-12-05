using GMall.Types;
using GS.Domain;
using System.Threading.Tasks;

namespace GMall.Order.Domain.Orders.Repositories
{
    public interface IOrderRepository : IRepository<Order, OrderId>
    {
        Task<Order> GetByOrderNumberAsync(OrderNumber aOrderNumber);
    }
}
