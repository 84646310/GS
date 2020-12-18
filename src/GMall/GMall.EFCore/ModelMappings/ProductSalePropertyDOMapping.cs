using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations.Schema;

namespace GMall.EFCore
{
    public class ProductSalePropertyDOMapping : IEntityTypeConfiguration<ProductSalePropertyDO>
    {
        public void Configure(EntityTypeBuilder<ProductSalePropertyDO> builder)
        {
            builder.ToTable("TbProductSaleProperty");
            builder.HasKey(x => x.Id); 
            builder.Property(x => x.ProductId).HasColumnType("bigint").HasDefaultValueSql("0").IsRequired();
            builder.Property(x => x.PropertyId).HasColumnType("bigint").HasDefaultValueSql("0").IsRequired(); 
        }
    }
}
