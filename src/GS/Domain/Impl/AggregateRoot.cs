using System;
using System.Collections.Generic;
using System.Text;

namespace GS.Domain
{

    public abstract class AggregateRoot<TAggregateRootUniqueId, TPrimaryKey> : IAggregateRoot<TAggregateRootUniqueId>, ISurrogateId<TPrimaryKey>
    {
        public virtual TPrimaryKey Id { get; protected set; }
        public virtual TAggregateRootUniqueId UniqueId { get; protected set; }
        protected AggregateRoot(TAggregateRootUniqueId aAggregateRootUniqueId)
        {
            UniqueId = aAggregateRootUniqueId;
        }
    }
    public abstract class AggregateRoot<TAggregateRootUniqueId> : AggregateRoot<TAggregateRootUniqueId, int>
    {
        public AggregateRoot(TAggregateRootUniqueId aAggregateRootUniqueId) : base(aAggregateRootUniqueId)
        {
        }
    }

}
