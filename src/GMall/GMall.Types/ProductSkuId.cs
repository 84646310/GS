using GS.Domain;

namespace GMall.Types
{
    public class ProductSkuId : LongGuid
    {
        public ProductSkuId()
        { 
        }
        public ProductSkuId(long aValue) : base(aValue)
        { 
        }
    }
}
