using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations.Schema;

namespace GMall.EFCore
{
    public class ProductSkuDOMapping : IEntityTypeConfiguration<ProductSkuDO>
    {
        public void Configure(EntityTypeBuilder<ProductSkuDO> builder)
        {
            builder.ToTable("TbProductSku");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever().IsRequired();
            builder.Property(x => x.ProductId).HasColumnType("bigint").HasDefaultValueSql("0").IsRequired();
            builder.Property(x => x.SpecificationId).HasColumnType("bigint").HasDefaultValueSql("0").IsRequired();
            builder.Property(x => x.UnitPrice).HasColumnType("money").HasDefaultValueSql("0").IsRequired();
            builder.Property(x => x.Sellable).HasDefaultValue(0).IsRequired();
            builder.Property(x => x.Available).HasDefaultValue(0).IsRequired();
        }
    }
}
