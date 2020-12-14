using Microsoft.EntityFrameworkCore;

namespace GMall.EFCore
{
    public class GMallDbContext : DbContext
    {
        public GMallDbContext()
        {
            //Database.EnsureCreated();
        }
        public DbSet<TbBrand> TbBrand { get; set; }
        public DbSet<TbCategory> TbCategory { get; set; }
        public DbSet<TbPicture> TbPicture { get; set; }
        public DbSet<TbProduct> TbProduct { get; set; }
        public DbSet<TbProductSku> TbProductSku { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=.;database=GMallDB;uid=sa;pwd=123456");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TbBrandMapping());
            modelBuilder.ApplyConfiguration(new TbCategoryMapping());
            modelBuilder.ApplyConfiguration(new TbPictureMapping());
            modelBuilder.ApplyConfiguration(new TbProductMapping());
            modelBuilder.ApplyConfiguration(new TbProductSkuMapping());
        }
    }
}
