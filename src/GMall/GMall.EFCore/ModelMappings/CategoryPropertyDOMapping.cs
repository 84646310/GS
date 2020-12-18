using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GMall.EFCore
{
    public class CategoryPropertyDOMapping : IEntityTypeConfiguration<CategoryPropertyDO>
    {
        public void Configure(EntityTypeBuilder<CategoryPropertyDO> builder)
        {
            builder.ToTable("TbCategoryProperty");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CategoryId).HasColumnType("bigint").HasDefaultValueSql("0").IsRequired();
            builder.Property(x => x.PropertyId).HasColumnType("bigint").HasDefaultValueSql("0").IsRequired(); 
        }
    }
}
