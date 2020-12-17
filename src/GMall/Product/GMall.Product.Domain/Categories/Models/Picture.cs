﻿using GMall.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace GMall.Product.Domain.Categories
{
    public class Picture
    {
        public PictureUseType UseType { get; private set; }
        public PictureId PictureId { get; private set; }
        public Picture(PictureId aPictureId, PictureUseType aUseType)
        {
            UseType = aUseType;
            PictureId = aPictureId;
        }
    }
}
