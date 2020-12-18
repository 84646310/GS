using GMall.Types;
using GS.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace GMall.Product.Domain.Categories
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
