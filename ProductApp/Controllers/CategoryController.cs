using Microsoft.AspNetCore.Mvc;
using ProductApp.Controllers.Response;
using ProductDomain;
using ProductDomain.Entity;

namespace ProductApp.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository) 
        {
            this._categoryRepository = categoryRepository;
        }

        [HttpGet]
        public async Task<ServiceResponse<List<Category>>> GetCategories()
        {
            List<Category>? result = await _categoryRepository.FindAllCategoriesAsync();
            ServiceResponse<List<Category>>? serviceResponse = new ServiceResponse<List<Category>>();

            if (result == null || result.Count == 0)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = "没有更多数据";
            }
            else 
            {
                serviceResponse.Data = result;
            }
            return serviceResponse;
        }
    }
}
