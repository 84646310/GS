using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GMall.EFCore
{
    public class BrandPictureDOMapping : IEntityTypeConfiguration<BrandPictureDO>
    {
        public void Configure(EntityTypeBuilder<BrandPictureDO> builder)
        {
            builder.ToTable("TbBrandPicture");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.BrandId).HasColumnType("bigint").HasDefaultValueSql("0").IsRequired();
            builder.Property(x => x.PictureId).HasColumnType("bigint").HasDefaultValueSql("0").IsRequired();
            builder.Property(x => x.UseType).HasDefaultValue(0).IsRequired();
        }
    }
}
