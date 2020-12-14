using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GMall.EFCore
{
    public class TbProductMapping : IEntityTypeConfiguration<TbProduct>
    {
        public void Configure(EntityTypeBuilder<TbProduct> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
        }
    }
}
