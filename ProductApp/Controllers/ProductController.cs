using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductDomain;

namespace ProductApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            this._productRepository = productRepository;
        }
    }
}
