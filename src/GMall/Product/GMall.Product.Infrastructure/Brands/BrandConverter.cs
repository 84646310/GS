using GMall.EFCore;
using GMall.Product.Domain.Brands;
using System;
using System.Collections.Generic;
using System.Text;

namespace GMall.Product.Infrastructure
{
    public class BrandConverter
    {
        public Brand ToEntity(TbBrand obj)
        {
            var result = new Brand(new Types.BrandId(obj.Id)
                , obj.Name
                , new Logo(new Types.PictureId(1)));
            return result;
        }
        public IList<Brand> ToEntity(IList<TbBrand> objs)
        {
            var result = new List<Brand>();
            foreach (var item in objs)
            {
                result.Add(new Brand(new Types.BrandId(item.Id)
                , item.Name
                , new Logo(new Types.PictureId(1))));
            }
            return result;
        }
        public TbBrand ToDO(Brand obj)
        {
            var result = new TbBrand()
            {
                Id = obj.Id.Value,
                Name = obj.Name
            };
            return result;
        }
        public IList<TbBrand> ToDO(IList<Brand> objs)
        {
            var result = new List<TbBrand>();
            foreach (var item in objs)
            {
                result.Add(new TbBrand()
                {
                    Id = item.Id.Value,
                    Name = item.Name
                });
            }
            return result;
        }
    }
}
