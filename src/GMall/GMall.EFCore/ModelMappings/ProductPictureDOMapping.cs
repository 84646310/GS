using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations.Schema;

namespace GMall.EFCore
{
    public class ProductPictureDOMapping : IEntityTypeConfiguration<ProductPictureDO>
    {
        public void Configure(EntityTypeBuilder<ProductPictureDO> builder)
        {
            builder.ToTable("TbProductPicture");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();
            builder.Property(x => x.ProductId).HasColumnType("bigint").HasDefaultValueSql("0").IsRequired();
            builder.Property(x => x.PictureId).HasColumnType("bigint").HasDefaultValueSql("0").IsRequired();
            builder.Property(x => x.UseType).HasDefaultValue(0).IsRequired();
        }
    }
}
