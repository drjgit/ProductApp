using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductDomain.Entity;

namespace ProductInfrastructure.Configs
{
    public class ProductTypeConfig : IEntityTypeConfiguration<ProductType>
    {
        public void Configure(EntityTypeBuilder<ProductType> builder) 
        {
            builder.ToTable(name:$"T_{nameof(ProductType)}");
        }
    }
}
