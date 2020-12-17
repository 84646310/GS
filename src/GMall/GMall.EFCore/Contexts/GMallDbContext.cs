using Microsoft.EntityFrameworkCore;

namespace GMall.EFCore
{
    public class GMallDbContext : DbContext
    {
        public GMallDbContext()
        {
            Database.EnsureCreated();
        }
        public DbSet<BrandDO> BrandDO { get; set; }
        public DbSet<BrandPictureDO> BrandPictureDO { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=.;database=GMallDB;uid=sa;pwd=123456");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BrandDOMapping());
            modelBuilder.ApplyConfiguration(new BrandPictureDOMapping());
        }
    }
}
