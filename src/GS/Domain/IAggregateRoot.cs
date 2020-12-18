using System;
using System.Collections.Generic;
using System.Text;

namespace GS.Domain
{
    public interface IAggregateRoot
    {
    }
    public interface IAggregateRoot<TAggregateRootUniqueId> : IAggregateRoot
    {
        TAggregateRootUniqueId UniqueId { get; }
    }
}