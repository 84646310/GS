using System;
using System.Collections.Generic;
using System.Text;

namespace GS.Domain
{
    public interface IEntity
    {
    }
    public interface IEntity<TEntityId> : IEntity
    {
        TEntityId UniqueId { get; }
    }
}
