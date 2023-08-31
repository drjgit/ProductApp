using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductDomain.Entity;

namespace ProductInfrastructure.Configs
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable(name:$"T_{nameof(Product)}");
            builder.HasMany((Product x) => x.Variants).WithOne((ProductVariants x) => x.Product).HasForeignKey((ProductVariants x) => x.ProductId);
        }
    }
}