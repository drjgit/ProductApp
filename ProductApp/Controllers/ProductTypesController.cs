using Microsoft.AspNetCore.Mvc;
using ProductApp.Controllers.Response;
using ProductDomain;
using ProductDomain.Entity;

namespace ProductApp.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductTypesController : ControllerBase
    {
        private readonly IProductTypeRepository _productTypeRepository;

        public ProductTypesController(IProductTypeRepository productTypeRepository)
        {
            this._productTypeRepository = productTypeRepository;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<ProductType>>>> GetAllProductType() 
        {
            List<ProductType>? result = await _productTypeRepository.FindAllProductTypeAsync();
            ServiceResponse<List<ProductType>> serviceResponse = new ServiceResponse<List<ProductType>>() { Data = result };
            return serviceResponse;
        }
    }
}
