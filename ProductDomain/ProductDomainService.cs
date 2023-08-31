
namespace ProductDomain
{
    internal class ProductDomainService
    {
        private readonly IProductRepository _repository;
        public ProductDomainService(IProductRepository productRepository) 
        {
            _repository = productRepository;
        }   
    }
}
