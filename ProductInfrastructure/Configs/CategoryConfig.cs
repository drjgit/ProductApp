using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductDomain.Entity;

namespace ProductInfrastructure.Configs
{
    public class CategoryConfig : IEntityTypeConfiguration<Category>  
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable(name:$"T_{nameof(Category)}");
        }
    }
}
