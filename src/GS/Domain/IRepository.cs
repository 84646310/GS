using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GS.Domain
{
    public interface IRepository
    { 
    }
    public interface IRepository<TAggregateRoot, TAggregateRootId> : IRepository where TAggregateRoot : IAggregateRoot
    {
        Task<TAggregateRoot> GetAsync(TAggregateRootId aAggregateRootId);
        Task SaveAsync(TAggregateRoot aAggregateRoot);
        //Task SaveAllAsync(ICollection<TAggregateRoot> aAggregateRootCollection);
        //Task Remove(TAggregateRoot aAggregateRoot);
        //Task RemoveAll(ICollection<TAggregateRoot> aAggregateRootCollection);
        //Task<int> SizeAsync();
    }
}
