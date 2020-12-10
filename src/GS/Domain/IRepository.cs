using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GS.Domain
{
    public interface IRepository
    {
        //Task<IAggregateRoot> GetAsync(object aAggregateRootId);
        //Task SaveAsync(IAggregateRoot aAggregateRoot);
    }
    public interface IRepository<TAggregateRoot, TAggregateRootId> : IRepository where TAggregateRoot : IAggregateRoot
    {
        //Task<TAggregateRootId> NextIdAsync();
        Task<TAggregateRoot> GetByIdAsync(TAggregateRootId aAggregateRootId);
        Task SaveAsync(TAggregateRoot aAggregateRoot);
        Task SaveAsync(IEnumerable<TAggregateRoot> aAggregateRoot);
        //Task SaveAllAsync(ICollection<TAggregateRoot> aAggregateRootCollection);
        //Task Remove(TAggregateRoot aAggregateRoot);
        //Task RemoveAll(ICollection<TAggregateRoot> aAggregateRootCollection);
        //Task<int> SizeAsync();
    }
}
