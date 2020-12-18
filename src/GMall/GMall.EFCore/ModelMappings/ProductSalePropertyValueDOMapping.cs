using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GMall.EFCore
{
    public class ProductSalePropertyValueDOMapping : IEntityTypeConfiguration<ProductSalePropertyValueDO>
    {
        public void Configure(EntityTypeBuilder<ProductSalePropertyValueDO> builder)
        {
            builder.ToTable("TbProductSalePropertyValue");
            builder.HasKey(x => x.Id); 
            builder.Property(x => x.ProductId).HasColumnType("bigint").HasDefaultValueSql("0").IsRequired();
            builder.Property(x => x.PropertyId).HasColumnType("bigint").HasDefaultValueSql("0").IsRequired();
            builder.Property(x => x.PropertyId).HasColumnType("bigint").HasDefaultValueSql("0").IsRequired();
        }
    }
}
