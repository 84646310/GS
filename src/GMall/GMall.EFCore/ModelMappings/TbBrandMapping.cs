using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GMall.EFCore
{
    public class TbBrandMapping : IEntityTypeConfiguration<TbBrand>
    {
        public void Configure(EntityTypeBuilder<TbBrand> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
        }
    }
}
