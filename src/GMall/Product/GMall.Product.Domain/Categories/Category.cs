using GMall.Types;
using GS.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace GMall.Product.Domain.Categories
{
    public class Category : AggregateRoot<CategoryId>
    {
        public CategoryId ParentId { get; private set; }
        public string Name { get; private set; }
        public ICollection<PictureId> PictureIds { get; private set; }
        public ICollection<PropertyInfo> PropertyInfos { get; private set; }
        public Category(CategoryId aId, CategoryId aParentId, string aName, ICollection<PictureId> aPictureIds, ICollection<PropertyInfo> aPropertyInfos) : base(aId)
        {
            ParentId = aParentId;
            Name = aName;
            PictureIds = aPictureIds;
            PropertyInfos = aPropertyInfos;
        }
    }
}
