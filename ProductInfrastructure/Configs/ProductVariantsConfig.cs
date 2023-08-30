using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductDomain.Entity;

namespace ProductInfrastructure.Configs
{
    public class ProductVariantsConfig : IEntityTypeConfiguration<ProductVariants>
    {
        public void Configure(EntityTypeBuilder<ProductVariants> builder)
        {
            builder.ToTable(name:$"T_{nameof(ProductVariants)}");
            builder.HasKey((ProductVariants x) => new { x.ProductId, x.ProductTypeId });
            builder.Property((ProductVariants x) => x.Price).HasColumnType(typeName:"decimal(18,2)");
            builder.Property((ProductVariants x) => x.OriginalPrice).HasColumnType(typeName: "decimal(18,2)");
        }
    }
}
