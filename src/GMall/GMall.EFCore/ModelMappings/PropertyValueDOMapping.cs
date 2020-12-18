using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations.Schema;

namespace GMall.EFCore
{
    public class PropertyValueDOMapping : IEntityTypeConfiguration<PropertyValueDO>
    {
        public void Configure(EntityTypeBuilder<PropertyValueDO> builder)
        {
            builder.ToTable("TbPropertyValueDO");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever().IsRequired(); 
            builder.Property(x => x.PropertyId).HasColumnType("bigint").HasDefaultValueSql("0").IsRequired();
            builder.Property(x => x.Name).HasColumnType("nvarchar(50)").IsRequired();
            builder.Property(x => x.Sort).HasDefaultValue(0).IsRequired();
        }
    }
}
