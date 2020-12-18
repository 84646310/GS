using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GMall.EFCore
{
    public class CategoryPropertyValueDOMapping : IEntityTypeConfiguration<CategoryPropertyValueDO>
    {
        public void Configure(EntityTypeBuilder<CategoryPropertyValueDO> builder)
        {
            builder.ToTable("TbCategoryPropertyValue");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CategoryId).HasColumnType("bigint").HasDefaultValueSql("0").IsRequired();
            builder.Property(x => x.PropertyId).HasColumnType("bigint").HasDefaultValueSql("0").IsRequired();
            builder.Property(x => x.PropertyValueId).HasColumnType("bigint").HasDefaultValueSql("0").IsRequired();
        }
    }
}
