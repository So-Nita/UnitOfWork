using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductStock.Model.Product;

namespace ProductStock.EntityConfiguration
{
    public class EntityProduct : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(e => e.Id);
            builder.HasIndex(e => e.Name).IsUnique();
            
            builder.Property(e=>e.Id).IsRequired().HasColumnType("varchar").HasMaxLength(36);
            builder.Property(e => e.Name).IsRequired().HasColumnType("nvarchar").HasMaxLength(50).IsUnicode();
            builder.Property(e => e.Price).IsRequired(false).HasColumnType("float");
            builder.Property(e => e.Description).IsRequired(false).HasColumnType("nvarchar(50)").HasMaxLength(50);

        }
    }
}
