using GMall.Types;
using GS.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace GMall.Product.Domain.Categories
{
    public class Category : AggregateRoot<CategoryId>
    {
        public CategoryInfo Info { get; private set; }
        public ICollection<Picture> Pictures { get; private set; }
        public ICollection<PropertyInfo> PropertyInfos { get; private set; }
        public int Sort { get; private set; }
        public bool Active { get; private set; }
        public Category(CategoryId aId, CategoryInfo aInfo, ICollection<Picture> aPictures, ICollection<PropertyInfo> aPropertyInfos, int aSort, bool aActive) : base(aId)
        {
            Info = aInfo;
            Pictures = aPictures;
            PropertyInfos = aPropertyInfos;
            Sort = aSort;
            Active = aActive;
        }
        public void Update(CategoryInfo aInfo)
        {
            Info = aInfo;
        }
        public void UpdatePictures(ICollection<Picture> aPictures)
        {
            Pictures = aPictures;
        }
        public void UpdateSort(int aSort)
        {
            Sort = aSort;
        }
        public void Activate()
        {
            Active = true;
        }
        public void Deactivate()
        {
            Active = false;
        }
    }
}
