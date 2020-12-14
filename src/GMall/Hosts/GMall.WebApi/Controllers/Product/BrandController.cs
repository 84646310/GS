using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GMall.Product.Application;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GMall.WebApi.Controllers.Product
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        private readonly IBrandApplicationService brandApplicationService;
        public BrandController(IBrandApplicationService aBrandApplicationService)
        {
            brandApplicationService = aBrandApplicationService;
        }
        [HttpPost]
        public async Task PostAsync(BrandDTO aBrandDTO)
        {
            await brandApplicationService.Add(aBrandDTO);
        }
        [HttpGet]
        public async Task<BrandDTO> GetAsync(long id)
        {
            var result = await brandApplicationService.Get(id);
            return result;
        }
    }
}
