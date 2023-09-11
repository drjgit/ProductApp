using Microsoft.AspNetCore.Mvc;
using ProductApp.Controllers.Response;
using ProductDomain;
using ProductDomain.Entity;

namespace ProductApp.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            this._productRepository = productRepository;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Product>>>> GetProductList()
        {
            List<Product>? result = await _productRepository.FindAllProductsAsync();
            ServiceResponse<List<Product>>? serviceResponse = new ServiceResponse<List<Product>>();
            if (result.Count == 0)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = "没有更多的数据";
            }
            else
            {
                serviceResponse.Data = result;
            }
            return Ok(serviceResponse);
        }

        [HttpGet(template: "{productId}")]
        public async Task<ActionResult<ServiceResponse<Product>>> GerProductById(Guid productId)
        {
            Product? product = await _productRepository.FindProductByIdAsync(productId);
            ServiceResponse<Product>? serviceResponse = new ServiceResponse<Product>() { Data = product };

            return Ok(serviceResponse);
        }

        [HttpGet(template: "{categoryUrl}")]
        public async Task<ActionResult<ServiceResponse<List<Product>>>> GetProductByCategory(string categoryUrl)
        { 
            List<Product>? result = await _productRepository.FindProductByCategoryAsync(categoryUrl);

            ServiceResponse<List<Product>>? serviceResponse = new ServiceResponse<List<Product>>() { Data = result };

            return Ok(serviceResponse); 
        }

        [HttpGet(template: "{searchText}")]
        public async Task<ActionResult<ServiceResponse<List<Product>>>> GetProductBySearch(string searchText)
        {
            List<Product>? result = await _productRepository.FindProductBySearchAsync(searchText);

            ServiceResponse<List<Product>>? serviceResult = new ServiceResponse<List<Product>>() { Data = result };

            return Ok(serviceResult);
        }

        [HttpGet(template: "{searchText}")]
        public async Task<ActionResult<ServiceResponse<List<Product>>>> GetProductBySearchSuggestions(string searchText)
        {
            List<Product>? result = await _productRepository.FindProductBySearchSuggestions(searchText);

            ServiceResponse<List<Product>>? serviceResult = new ServiceResponse<List<Product>>() { Data = result };

            return Ok(serviceResult);
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Product>>>> GetProductByFeature()
        {
            List<Product>? result = await _productRepository.FindProductByFeatureAsync();

            ServiceResponse<List<Product>>? serviceResult = new ServiceResponse<List<Product>>() { Data = result };

            return Ok(serviceResult);
        }
    }
}
