using Microsoft.EntityFrameworkCore;
using ProductDomain.Entity;

namespace ProductInfrastructure.dbContexts
{
    public class ProductDBContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<ProductVariants> ProductVariantss { get; set; }    
        public DbSet<Category> Categories { get; set; }

        public ProductDBContext(DbContextOptions options) :base(options) 
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
        }
    }
}
