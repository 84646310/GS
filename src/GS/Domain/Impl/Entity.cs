using System;
using System.Collections.Generic;
using System.Text;

namespace GS.Domain
{
    public abstract class Entity : IEntity
    {
    }
    public abstract class Entity<TEntityId> : IEntity<TEntityId>
    {
        public virtual TEntityId UId { get; protected set; }
        public Entity(TEntityId aEntityId)
        {
            UId = aEntityId;
        }

    }
}
