using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations.Schema;

namespace GMall.EFCore
{
    public class ProductSpecificationPropertyDOMapping : IEntityTypeConfiguration<ProductSpecificationPropertyDO>
    {
        public void Configure(EntityTypeBuilder<ProductSpecificationPropertyDO> builder)
        {
            builder.ToTable("TbProductSpecificationProperty");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever().IsRequired();
            builder.Property(x => x.ProductId).HasColumnType("bigint").HasDefaultValueSql("0").IsRequired();
            builder.Property(x => x.SpecificationId).HasColumnType("bigint").HasDefaultValueSql("0").IsRequired();
            builder.Property(x => x.PropertyId).HasColumnType("bigint").HasDefaultValueSql("0").IsRequired();
            builder.Property(x => x.Property).HasColumnType("nvarchar(50)").IsRequired();
            builder.Property(x => x.PropertyValueId).HasColumnType("bigint").HasDefaultValueSql("0").IsRequired();
            builder.Property(x => x.PropertyValue).HasColumnType("nvarchar(50)").IsRequired();
        }
    }
}
