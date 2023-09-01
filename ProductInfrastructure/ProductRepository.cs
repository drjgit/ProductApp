using Microsoft.EntityFrameworkCore;
using ProductDomain;
using ProductDomain.Entity;
using ProductInfrastructure.dbContexts;

namespace ProductInfrastructure
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductDBContext _dbContext;

        public ProductRepository(ProductDBContext productDBContext) 
        {
            _dbContext = productDBContext;
        }
        public async Task<List<Product>> FindAllProductsAsync()
        {
            return await _dbContext.Products.Include((Product x) => x.Variants.Where((ProductVariants y) => y.Deleted == false && y.Visiable == true)).Where((Product x) => x.Deleted == false && x.Visiable == true).ToListAsync();
        }

        public async Task<Product> FindProductByIdAsync(Guid productId)
        {
            //return await _dbContext.Products.Include();
            throw new NotImplementedException();
        }

        public async Task<List<Product>> FindProductByCategoryAsync(string categoryUrl)
        {
            return await _dbContext.Products.Where((Product x) => x.Deleted == false && x.Visiable == true && x.Category.Url.ToLower().Equals(categoryUrl.ToLower())).Include((Product v) => v.Variants.Where((ProductVariants x) => x.Deleted == false && x.Visiable == true)).ToListAsync();
        }

        public Task<List<Product>> FindProductBySearch(string searchText)
        {
            throw new NotImplementedException();
        }

        public Task<List<Product>> FindProductBySearchSuggestions(string searchText)
        {
            throw new NotImplementedException();
        }

        public Task<List<Product>> FindProductByFeatureAsync()
        {
            throw new NotImplementedException();
        }

    }
}
