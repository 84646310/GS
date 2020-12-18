using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations.Schema;

namespace GMall.EFCore
{
    public class ProductSpecificationDOMapping : IEntityTypeConfiguration<ProductSpecificationDO>
    {
        public void Configure(EntityTypeBuilder<ProductSpecificationDO> builder)
        {
            builder.ToTable("TbProductSpecification");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever().IsRequired();
            builder.Property(x => x.ProductId).HasColumnType("bigint").HasDefaultValueSql("0").IsRequired();
            builder.Property(x => x.PropertyString).HasColumnType("nvarchar(1000)").IsRequired();
        }
    }
}
