using GMall.Types;
using GS.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace GMall.Product.Domain.Brands
{
    public class Picture : Entity<int>
    {
        public PictureId PictureId { get; private set; }
        public PictureUseType UseType { get; private set; }
        public Picture(int aId, PictureId aPictureId, PictureUseType aUseType) : base(aId)
        {
            UseType = aUseType;
            PictureId = aPictureId;
        }
    }
}
