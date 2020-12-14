using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GMall.EFCore
{
    public class TbPictureMapping : IEntityTypeConfiguration<TbPicture>
    {
        public void Configure(EntityTypeBuilder<TbPicture> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.RemoteUrl).HasColumnType("varchar").IsRequired().HasMaxLength(200); 
        }
    }
}
