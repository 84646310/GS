using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations.Schema;

namespace GMall.EFCore
{
    public class ProductPropertyDOMapping : IEntityTypeConfiguration<ProductPropertyDO>
    {
        public void Configure(EntityTypeBuilder<ProductPropertyDO> builder)
        {
            builder.ToTable("TbProductProperty");
            builder.HasKey(x => x.Id); 
            builder.Property(x => x.ProductId).HasColumnType("bigint").HasDefaultValueSql("0").IsRequired();
            builder.Property(x => x.PropertyId).HasColumnType("bigint").HasDefaultValueSql("0").IsRequired();
            builder.Property(x => x.PropertyValueId).HasColumnType("bigint").HasDefaultValueSql("0").IsRequired();
            builder.Property(x => x.PropertyValue).HasColumnType("nvarchar(50)");
        }
    }
}
