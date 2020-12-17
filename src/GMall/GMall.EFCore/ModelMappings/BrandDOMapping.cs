using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations.Schema;

namespace GMall.EFCore
{
    public class BrandDOMapping : IEntityTypeConfiguration<BrandDO>
    {
        public void Configure(EntityTypeBuilder<BrandDO> builder)
        {
            builder.ToTable("TbBrand");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();
            builder.Property(x => x.Name).HasColumnType("nvarchar(50)").IsRequired();
            builder.Property(x => x.Sort).HasDefaultValue(0).IsRequired();
            builder.Property(x => x.Active).HasColumnType("bit").HasDefaultValueSql("0").IsRequired();
            builder.Property(x => x.Url).HasColumnType("varchar(50)");
        }
    }
}
