using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GMall.EFCore
{
    public class CategoryPictureDOMapping : IEntityTypeConfiguration<CategoryPictureDO>
    {
        public void Configure(EntityTypeBuilder<CategoryPictureDO> builder)
        {
            builder.ToTable("TbCategoryPicture");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CategoryId).HasColumnType("bigint").HasDefaultValueSql("0").IsRequired();
            builder.Property(x => x.PictureId).HasColumnType("bigint").HasDefaultValueSql("0").IsRequired();
            builder.Property(x => x.UseType).HasDefaultValue(0).IsRequired();
        }
    }
}
