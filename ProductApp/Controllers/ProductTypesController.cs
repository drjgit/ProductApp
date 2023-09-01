using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductApp.Controllers.Response;
using ProductDomain;
using ProductDomain.Entity;

namespace ProductApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductTypesController : ControllerBase
    {
        private readonly IProductTypeRepository _productTypeRepository;

        public ProductTypesController(IProductTypeRepository productTypeRepository)
        {
            this._productTypeRepository = productTypeRepository;
        }

        [HttpGet]
        public Task<ActionResult<ServiceResponse<List<ProductType>>>> GetAllProductType() 
        {

        }


    }
}
