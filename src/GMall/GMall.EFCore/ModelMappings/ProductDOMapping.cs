using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations.Schema;

namespace GMall.EFCore
{
    public class ProductDOMapping : IEntityTypeConfiguration<ProductDO>
    {
        public void Configure(EntityTypeBuilder<ProductDO> builder)
        {
            builder.ToTable("TbProduct");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();
            builder.Property(x => x.Name).HasColumnType("nvarchar(50)").IsRequired();
            builder.Property(x => x.ModelCode).HasColumnType("varchar(50)");
            builder.Property(x => x.Description).HasColumnType("nvarchar(2000)");
            builder.Property(x => x.Introduction).HasColumnType("nvarchar(4000)");
            builder.Property(x => x.BrandId).HasColumnType("bigint").HasDefaultValueSql("0").IsRequired();
            builder.Property(x => x.CategoryId).HasColumnType("bigint").HasDefaultValueSql("0").IsRequired();
        }
    }
}
