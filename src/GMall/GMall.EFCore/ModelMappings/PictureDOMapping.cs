using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations.Schema;

namespace GMall.EFCore
{
    public class PictureDOMapping : IEntityTypeConfiguration<PictureDO>
    {
        public void Configure(EntityTypeBuilder<PictureDO> builder)
        {
            builder.ToTable("TbPicture");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();
            builder.Property(x => x.RemoteUrl).HasColumnType("varchar(50)");
            builder.Property(x => x.LocalPath).HasColumnType("varchar(50)");
        }
    }
}
