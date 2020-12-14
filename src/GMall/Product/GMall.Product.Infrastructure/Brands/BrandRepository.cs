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
        public async Task<Brand> GetByIdAsync(BrandId aAggregateRootId)
        {
            var doModel = await _context.TbBrand.FindAsync(aAggregateRootId.Value);
            return _converter.ToEntity(doModel);
        }

        public async Task SaveAsync(Brand aAggregateRoot)
        {
            var doModel = _converter.ToDO(aAggregateRoot);
            await _context.Set<TbBrand>().AddAsync(doModel);
            await _context.SaveChangesAsync();
        }

        public async Task SaveAsync(IList<Brand> aAggregateRootS)
        {
            var doModel = _converter.ToDO(aAggregateRootS);
            await _context.Set<TbBrand>().AddRangeAsync(doModel);
            await _context.SaveChangesAsync();
        }
    }
}
