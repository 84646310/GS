using System;
using System.Collections.Generic;
using System.Text;

namespace GS.Domain
{
    public abstract class Entity<TEntityId> : IEntity
    {
        public TEntityId Id { get; protected set; }
        protected Entity(TEntityId aId)
        {
            Id = aId;
        }
    }
}
