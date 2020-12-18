using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations.Schema;

namespace GMall.EFCore
{
    public class CategoryDOMapping : IEntityTypeConfiguration<CategoryDO>
    {
        public void Configure(EntityTypeBuilder<CategoryDO> builder)
        {
            builder.ToTable("TbCategory");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();
            builder.Property(x => x.ParentId).HasColumnType("bigint").HasDefaultValue(0).IsRequired();
            builder.Property(x => x.Name).HasColumnType("nvarchar(50)").IsRequired();
            builder.Property(x => x.Sort).HasDefaultValue(0).IsRequired();
            builder.Property(x => x.Active).HasColumnType("bit").HasDefaultValueSql("0").IsRequired();
        }
    }
}
