using GMall.Types;
using GS.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace GMall.Product.Domain.Brands
{
    public class BrandInfo : ValueObject
    {
        public string Name { get; private set; }
        public string Url { get; private set; }
        public BrandInfo(string aName, string aUrl)
        {
            if (string.IsNullOrWhiteSpace(aName))
                throw new ArgumentException("品牌名称不能为空");
            if (aName.Length > 50)
                throw new ArgumentException("品牌名称长度不能超过50"); 

            Name = aName;
            Url = aUrl;
        }
    }
}
