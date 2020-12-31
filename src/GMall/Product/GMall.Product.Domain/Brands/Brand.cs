using GMall.Types;
using GS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GMall.Product.Domain.Brands
{
    public class Brand : AggregateRoot<BrandId>
    {
        public BrandInfo Info { get; private set; }
        public int Sort { get; private set; }
        public bool Enabled { get; private set; }
        public ICollection<Picture> Pictures { get; private set; }
        public Brand(BrandId aBrandId, BrandInfo aInfo, int aSort, bool aEnabled, ICollection<Picture> aPictureCollection) : base(aBrandId)
        {
            if (aBrandId == null)
                throw new ArgumentException("Id不能为空");
            if (aInfo == null)
                throw new ArgumentException("品牌信息不能为空");

            Info = aInfo;
            Pictures = aPictureCollection;
            Sort = aSort;
            Enabled = aEnabled;
        }
        public void Update(BrandInfo aInfo)
        {
            if (aInfo == null)
                throw new ArgumentException("品牌信息不能为空");
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
    }
}
