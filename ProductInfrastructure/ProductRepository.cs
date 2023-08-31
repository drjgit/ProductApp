using ProductDomain;
using ProductDomain.Entity;

namespace ProductInfrastructure
{
    public class ProductRepository : IProductRepository
    {
        public Task<List<Product>> FindAllProductsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Product> FindProductByIdAsync(Guid productId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Product>> FindProductByCategoryAsync(string categoryUrl)
        {
            throw new NotImplementedException();
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
