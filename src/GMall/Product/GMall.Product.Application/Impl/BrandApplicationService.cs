using GMall.Product.Domain.Brands.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GMall.Product.Application
{
    public class BrandApplicationService : IBrandApplicationService
    {
        private readonly IBrandRepository brandRepository;
        private readonly BrandAssembler brandAssembler;
        public BrandApplicationService(IBrandRepository aBrandRepository)
        {
            brandRepository = aBrandRepository;
            brandAssembler = new BrandAssembler();
        }
        public async Task Add(BrandDTO aBrandDTO)
        {
            var entity = brandAssembler.ToEntity(aBrandDTO);
            await brandRepository.SaveAsync(entity);
        }

        public async Task<BrandDTO> Get(long id)
        {
            var entity = await brandRepository.GetByIdAsync(new Types.BrandId(id));
            var result = brandAssembler.ToDTO(entity);
            return result;
        }
    }
}
