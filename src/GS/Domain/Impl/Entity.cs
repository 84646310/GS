using System;
using System.Collections.Generic;
using System.Text;

namespace GS.Domain
{
    public abstract class Entity<TEntityUniqueId, TPrimaryKey> : IEntity<TEntityUniqueId>, ISurrogateId<TPrimaryKey>
    {
        public virtual TPrimaryKey Id { get; protected set; }
        public virtual TEntityUniqueId UniqueId { get; protected set; } 
        protected Entity(TEntityUniqueId aTEntityUniqueId)
        {
            UniqueId = aTEntityUniqueId;
        }
    }
    public abstract class Entity<TEntityUniqueId> : Entity<TEntityUniqueId, int>
    {
        public Entity(TEntityUniqueId aEntityUniqueId) : base(aEntityUniqueId)
        {
        }
    }
}
