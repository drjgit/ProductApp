using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using ProductDomain;
using ProductDomain.Entity;
using ProductInfrastructure.dbContexts;

namespace ProductInfrastructure
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ProductDBContext _dbContext;
        public CategoryRepository(ProductDBContext dbContext) 
        {
            _dbContext = dbContext;
        }
        public async Task<List<Category>> FindAllCategoriesAsync()
        {
            List<Category>? result = await _dbContext.Categories.Where((Category x) => x.Deleted == false && x.Visiable == true).ToListAsync();
            return result;
        }
    }
}
