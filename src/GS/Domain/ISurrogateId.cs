using System;
using System.Collections.Generic;
using System.Text;

namespace GS.Domain
{
    public interface ISurrogateId
    {
    }
    public interface ISurrogateId<TPrimaryKey> : ISurrogateId
    {
        TPrimaryKey Id { get; }
    }
}
