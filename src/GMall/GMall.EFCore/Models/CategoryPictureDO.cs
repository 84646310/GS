using System;
using System.Collections.Generic;
using System.Text;

namespace GMall.EFCore.Models
{
    public class CategoryPictureDO
    {
        public int CategoryId { get; set; }
        public int UseType { get; set; }
        public long PictureId { get; set; }
    }
}
