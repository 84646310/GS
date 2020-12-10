using GS.Domain;

namespace GMall.Types
{
    public class ProductId : LongGuid
    {
        public ProductId()
        { 
        }
        public ProductId(long aValue) : base(aValue)
        { 
        }
    }
}
