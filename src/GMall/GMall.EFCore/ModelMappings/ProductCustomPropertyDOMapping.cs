using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GMall.EFCore
{
    public class ProductCustomPropertyDOMapping : IEntityTypeConfiguration<ProductCustomPropertyDO>
    {
        public void Configure(EntityTypeBuilder<ProductCustomPropertyDO> builder)
        {
            builder.ToTable("TbProductCustomProperty");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.ProductId).HasColumnType("bigint").HasDefaultValueSql("0").IsRequired();
            builder.Property(x => x.PropertyId).HasColumnType("bigint").HasDefaultValueSql("0").IsRequired();
            builder.Property(x => x.PropertyValue).HasColumnType("nvarchar(50)");
        }
    }
}
