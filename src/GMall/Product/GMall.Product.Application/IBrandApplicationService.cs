using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GMall.Product.Application
{
    public interface IBrandApplicationService
    {
        Task Add(BrandDTO brand);
        Task<BrandDTO> Get(long id);
    }
}
