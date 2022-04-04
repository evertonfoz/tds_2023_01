using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TDS_CA_MS.Domain.Entities;

namespace TDS_CA_MS.Infra.Data.EntitiesConfiguration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.ProductID);
            builder.Property(p => p.Description).
                HasMaxLength(100).IsRequired();
            builder.Property(p => p.Price).
                HasPrecision(10, 2).IsRequired();
        }
    }
}
