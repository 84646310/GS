using GMall.Types;
using GS.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GMall.Product.Domain.Brands.Repositories
{
    public interface IBrandRepository : IRepository<Brand, BrandId>
    {
        Task<BrandIndex> GetByName(string aName);
    }
}
