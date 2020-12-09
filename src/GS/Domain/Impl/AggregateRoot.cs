using System;
using System.Collections.Generic;
using System.Text;

namespace GS.Domain
{
    public abstract class AggregateRoot<TAggregateRootId> : IAggregateRoot
    {
        public TAggregateRootId Id { get; protected set; } 
        protected AggregateRoot(TAggregateRootId aId)
        {
            Id = aId;
        }
    }
}
