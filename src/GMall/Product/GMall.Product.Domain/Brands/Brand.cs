using GMall.Types;
using GS.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace GMall.Product.Domain.Brands
{
    public class Brand : AggregateRoot<BrandId>
    {
        public BrandInfo Info { get; private set; }
        public int Sort { get; private set; }
        public bool Active { get; private set; }
        public ICollection<Picture> Pictures { get; private set; }
        public Brand(BrandId aBrandId, BrandInfo aInfo, ICollection<Picture> aPictures, int aSort, bool aActive) : base(aBrandId)
        {
            Info = aInfo;
            Pictures = aPictures;
            Sort = aSort;
            Active = aActive;
        }
        public void Update(BrandInfo aInfo)
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
