using GS.Domain;

namespace GMall.Types
{
    public class CategoryId : LongGuid
    {
        public CategoryId()
        {

        }
        public CategoryId(long aValue):base(aValue)
        { 
        }
    }
}
