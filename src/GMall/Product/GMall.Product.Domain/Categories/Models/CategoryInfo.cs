using GMall.Types;
using GS.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace GMall.Product.Domain.Categories
{
    public class CategoryInfo:IValueObject
    {
        public CategoryId ParentId { get; private set; }
        public string Name { get; private set; }
        public CategoryInfo(CategoryId aParentId, string aName)
        {
            if (string.IsNullOrWhiteSpace(aName))
                throw new ArgumentException("分类名称不能为空");
            ParentId = aParentId;
            Name = aName; 
        }
    }
}
