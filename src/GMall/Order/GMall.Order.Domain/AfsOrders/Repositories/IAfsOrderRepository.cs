using GMall.Types;
using GS.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GMall.Order.Domain.AfsOrders.Repositories
{
    public interface IAfsOrderRepository : IRepository<AfsOrder, AfsOrderId>
    {
        Task<ICollection<AfsOrder>> GetByOrderIdAsync(OrderId aOrderId);
    }
}
