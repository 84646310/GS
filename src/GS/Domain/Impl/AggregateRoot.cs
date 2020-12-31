using System;
using System.Collections.Generic;
using System.Text;

namespace GS.Domain
{
    public abstract class AggregateRoot<TAggregateRootId> : IAggregateRoot<TAggregateRootId>
    {
        public virtual TAggregateRootId UId { get; protected set; }
        public AggregateRoot(TAggregateRootId aAggregateRootId)
        {
            UId = aAggregateRootId;
        }
    }

}
