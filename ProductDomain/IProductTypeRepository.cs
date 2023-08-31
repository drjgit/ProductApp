
namespace ProductDomain
{
    public interface IProductTypeRepository
    {
        Task<List<Entity.ProductType>> FindAllProductTypeAsync();
        Task<List<Entity.ProductType>> GetProductTypeByProductIdAsync(Guid productId);
    }
}
