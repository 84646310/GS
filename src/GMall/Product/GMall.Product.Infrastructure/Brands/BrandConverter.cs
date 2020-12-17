using GMall.EFCore;
using GMall.Product.Domain.Brands;
using GS.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace GMall.Product.Infrastructure
{
    public class BrandConverter : IDataConverter
    {
        //public Brand ToEntity(TbBrand obj)
        //{
        //    var result = new Brand(new Types.BrandId(obj.Id)
        //        , null
        //        , null
        //        , 0
        //        , true);
        //    return result;
        //}
        //public IList<Brand> ToEntity(IList<TbBrand> objs)
        //{
        //    var result = new List<Brand>();
        //    foreach (var item in objs)
        //    {
        //        result.Add(new Brand(new Types.BrandId(item.Id)
        //        , null
        //        , null
        //        , 0
        //        , true));
        //    }
        //    return result;
        //}
        //public TbBrand ToDO(Brand obj)
        //{
        //    var result = new TbBrand()
        //    {
        //        Id = obj.Id.Value
        //    };
        //    return result;
        //}
        //public IList<TbBrand> ToDO(IList<Brand> objs)
        //{
        //    var result = new List<TbBrand>();
        //    foreach (var item in objs)
        //    {
        //        result.Add(new TbBrand()
        //        {
        //            Id = item.Id.Value
        //        });
        //    }
        //    return result;
        //}
    }
}
