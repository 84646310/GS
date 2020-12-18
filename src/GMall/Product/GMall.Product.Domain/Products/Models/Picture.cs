using GMall.Types;
using GS.Domain;

namespace GMall.Product.Domain.Products
{
    public class Picture : Entity<int>
    {
        public PictureUseType UseType { get; private set; }
        public PictureId PictureId { get; private set; }
        public Picture(int aUniqueId, PictureId aPictureId, PictureUseType aUseType) : base(aUniqueId)
        {
            UseType = aUseType;
            PictureId = aPictureId;
        }
    }
}
