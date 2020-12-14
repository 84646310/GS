using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GMall.EFCore
{
    public class TbProductSkuMapping : IEntityTypeConfiguration<TbProductSku>
    {
        public void Configure(EntityTypeBuilder<TbProductSku> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.ProductId).HasDefaultValue("0").IsRequired();
            builder.Property(x => x.SpecificationId).HasDefaultValue("0").IsRequired();
        }
    }
}
