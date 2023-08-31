using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using ProductDomain;
using ProductDomain.Entity;
using ProductInfrastructure.dbContexts;
using System.Linq;

namespace ProductInfrastructure
{
    public class ProductTypeRepository : IProductTypeRepository
    {
        private readonly ProductDBContext _dbContext;
        public ProductTypeRepository(ProductDBContext dBContext) 
        {
            _dbContext = dBContext;
        }
        public async Task<List<ProductType>> FindAllProductTypeAsync()
        {
            return await _dbContext.ProductTypes.ToListAsync();
        }

        public async Task<List<ProductType>> GetProductTypeByProductIdAsync(Guid productId)
        {
            List<ProductType> productTypes = new List<ProductType>();
            List<ProductVariants> result = await _dbContext.ProductVariantss.Where((ProductVariants x) => (x.Deleted == false && x.Visiable == true && x.ProductId == productId)).ToListAsync();
            foreach (var variant in result)
            {
                ProductType? type = await _dbContext.ProductTypes.SingleOrDefaultAsync((ProductType x) => x.Id == variant.ProductTypeId);
                productTypes.Add(type);
            }
            return productTypes;
        }
    }
}
