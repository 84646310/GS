using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations.Schema;

namespace GMall.EFCore
{
    public class PropertyDOMapping : IEntityTypeConfiguration<PropertyDO>
    {
        public void Configure(EntityTypeBuilder<PropertyDO> builder)
        {
            builder.ToTable("TbPropertyDO");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever().IsRequired(); 
            builder.Property(x => x.Name).HasColumnType("nvarchar(50)").IsRequired();
            builder.Property(x => x.Sort).HasDefaultValue(0).IsRequired();
        }
    }
}
