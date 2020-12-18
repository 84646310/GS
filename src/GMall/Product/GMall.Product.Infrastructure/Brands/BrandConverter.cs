using GMall.EFCore;
using GMall.Product.Domain.Brands;
using GMall.Types;
using GS.Infrastructure;
using System.Collections.Generic;

namespace GMall.Product.Infrastructure
{
    public class BrandConverter : IDataConverter
    {
        //public Brand ToEntity(BrandDO aBrandDO, ICollection<BrandPictureDO> aBrandPictureDOs)
        //{
        //    var result = new Brand(new BrandId(aBrandDO.Id)
        //        , new BrandInfo(aBrandDO.Name, aBrandDO.Url)
        //        , ToPictures(aBrandPictureDOs)
        //        , aBrandDO.Sort
        //        , aBrandDO.Active);
        //    return result;
        //}
        //public BrandDO ToDO(Brand aBrand)
        //{
        //    var result = new BrandDO()
        //    {
        //        Id = aBrand.Id.Value,
        //        Name = aBrand.Info.Name,
        //        Url = aBrand.Info.Url,
        //        Active = aBrand.Active,
        //        Sort = aBrand.Sort,
        //    };
        //    return result;
        //}
        //public ICollection<BrandPictureDO> ToBrandPictureDO(Brand aBrand)
        //{
        //    var result = ToBrandPictureDOs(aBrand);
        //    return result;
        //}

        //private ICollection<Picture> ToPictures(ICollection<BrandPictureDO> aBrandPictureDOs)
        //{
        //    var pictrueList = new List<Picture>();
        //    if (aBrandPictureDOs != null && aBrandPictureDOs.Count > 0)
        //    {
        //        foreach (var item in aBrandPictureDOs)
        //        {
        //            pictrueList.Add(new Picture(new PictureId(item.PictureId), (PictureUseType)item.UseType));
        //        }
        //    }
        //    return pictrueList;
        //}
        //private ICollection<BrandPictureDO> ToBrandPictureDOs(Brand aBrand)
        //{
        //    var pictrueList = new List<BrandPictureDO>();
        //    if (aBrand.Pictures != null && aBrand.Pictures.Count > 0)
        //    {
        //        foreach (var item in aBrand.Pictures)
        //        {
        //            pictrueList.Add(new BrandPictureDO()
        //            {
        //                BrandId = aBrand.Id.Value,
        //                PictureId = item.PictureId.Value,
        //                UseType = (int)item.UseType
        //            });
        //        }
        //    }
        //    return pictrueList;
        //}
    }
}
