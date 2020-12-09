using GMall.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace GMall.Product.Domain.Brands
{
    public class Logo
    {
        public PictureId PictureId { get; private set; }
        public Logo(PictureId aPictureId)
        {
            PictureId = aPictureId;
        }
    }
}
