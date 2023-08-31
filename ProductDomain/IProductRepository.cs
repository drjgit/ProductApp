
namespace ProductDomain
{
    public interface IProductRepository
    {
        Task<List<Entity.Product>> FindAllProductsAsync();
        Task<Entity.Product> FindProductByIdAsync(Guid productId);
        Task<List<Entity.Product>> FindProductByCategoryAsync(string categoryUrl);
        Task<List<Entity.Product>> FindProductBySearch(string searchText);
        Task<List<Entity.Product>> FindProductBySearchSuggestions(string searchText);
        Task<List<Entity.Product>> FindProductByFeatureAsync();
    }
}
