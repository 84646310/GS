using System;
using System.Collections.Generic;
using System.Text;

namespace GMall.EFCore
{
    public class CategoryPictureDO : BaseDO<int>
    {
        public int CategoryId { get; set; }
        public int UId { get; set; }
        public string PictureId { get; set; }
        public int UseType { get; set; }
    }
}
