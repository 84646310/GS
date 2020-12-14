using GMall.Product.Domain.Brands;
using System;
using System.Collections.Generic;
using System.Text;

namespace GMall.Product.Application
{
    public class BrandAssembler
    {
        public BrandDTO ToDTO(Brand aBrand)
        {
            var result = new BrandDTO()
            {
                Id = aBrand.Id.Value,
                Name = aBrand.Name
            };
            return result;
        }

        public Brand ToEntity(BrandDTO aBrandDTO)
        {
            var result = new Brand(new Types.BrandId(), aBrandDTO.Name, new Logo(new Types.PictureId(1)));
            return result;
        }
    }
}
