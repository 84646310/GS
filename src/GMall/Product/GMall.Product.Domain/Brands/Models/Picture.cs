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
            if (aId <= 0)
                throw new ArgumentException("Id不能小于或等于0");
            if (aPictureId == null)
                throw new ArgumentException("图片Id不能为空");
            PictureId = aPictureId;
            UseType = aUseType;
        }
        public void Update(PictureId aPictureId, PictureUseType aUseType)
        {
            PictureId = aPictureId;
            UseType = aUseType;
        }
    }
}
