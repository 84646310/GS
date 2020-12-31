using GMall.Types;
using GS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GMall.Product.Domain.Categories
{
    public class Category : AggregateRoot<CategoryId>
    {
        public CategoryInfo Info { get; private set; }
        public ICollection<Picture> Pictures { get; private set; }
        public ICollection<PropertyInfo> PropertyInfos { get; private set; }
        public int Sort { get; private set; }
        public bool Enabled { get; private set; }
        public Category(CategoryId aId, CategoryInfo aInfo, ICollection<Picture> aPictures, ICollection<PropertyInfo> aPropertyInfos, int aSort, bool aEnabled) : base(aId)
        {
            Info = aInfo;
            Pictures = aPictures;
            PropertyInfos = aPropertyInfos;
            Sort = aSort;
            Enabled = aEnabled;
        }
        public void Update(CategoryInfo aInfo)
        {
            Info = aInfo;
        }
        public void UpdateSort(int aSort)
        {
            Sort = aSort;
        }
        public void Enable()
        {
            Enabled = true;
        }
        public void Disable()
        {
            Enabled = false;
        }
        public void DeletePictures(ICollection<int> aPictureIdCollection)
        {
            if (Pictures != null && Pictures.Count > 0)
            {
                if (aPictureIdCollection != null && aPictureIdCollection.Count > 0)
                {
                    foreach (var item in aPictureIdCollection)
                    {
                        var removeItem = Pictures.FirstOrDefault(p => p.UId == item);
                        if (removeItem != null)
                            Pictures.Remove(removeItem);
                    }
                }
            }
        }
        public void AddOrUpdatePictures(ICollection<Picture> aPictureCollection)
        {
            if (aPictureCollection != null && aPictureCollection.Count > 0)
            {
                foreach (var item in aPictureCollection)
                {
                    var existItem = Pictures.FirstOrDefault(p => p.UId == item.UId);
                    if (existItem == null)
                    {
                        Pictures.Add(item);
                    }
                    else
                    {
                        existItem.Update(item.PictureId, item.UseType);
                    }
                }
            }
        } 
        public void DeletePropertyInfos(ICollection<int> aPropertyInfoIdCollection)
        {
            if (PropertyInfos != null && PropertyInfos.Count > 0)
            {
                if (aPropertyInfoIdCollection != null && aPropertyInfoIdCollection.Count > 0)
                {
                    foreach (var item in aPropertyInfoIdCollection)
                    {
                        var removeItem = PropertyInfos.FirstOrDefault(p => p.UId == item);
                        if (removeItem != null)
                            PropertyInfos.Remove(removeItem);
                    }
                }
            }
        }
        public void AddOrUpdatePropertyInfos(ICollection<PropertyInfo> aPropertyInfoCollection)
        {
            if (aPropertyInfoCollection != null && aPropertyInfoCollection.Count > 0)
            {
                foreach (var item in aPropertyInfoCollection)
                {
                    var existItem = PropertyInfos.FirstOrDefault(p => p.UId == item.UId);
                    if (existItem == null)
                    {
                        PropertyInfos.Add(item);
                    }
                    else
                    {
                        existItem.Update(item.PropertyId, item.PropertyValueIds);
                    }
                }
            }
        }
    }
}
