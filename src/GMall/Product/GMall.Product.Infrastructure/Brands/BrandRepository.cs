using GMall.EFCore;
using GMall.Product.Domain.Brands;
using GMall.Product.Domain.Brands.Repositories;
using GMall.Types;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GMall.Product.Infrastructure.Brands
{
    public class BrandRepository : IBrandRepository
    {
        private readonly GMallDbContext _context;
        private readonly BrandConverter _converter;
        public BrandRepository(GMallDbContext context)
        {
            _converter = new BrandConverter();
            _context = context;
        }

        public Task<Brand> GetAsync(BrandId aAggregateRootId)
        {
            throw new System.NotImplementedException();
        }

        public Task<BrandIndex> GetByName(string aName)
        {
            throw new System.NotImplementedException();
        }

        public Task SaveAsync(Brand aAggregateRoot)
        {
            throw new System.NotImplementedException();
        }
    }
}
