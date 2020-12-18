using Microsoft.EntityFrameworkCore;

namespace GMall.EFCore
{
    public class GMallDbContext : DbContext
    {
        public GMallDbContext()
        {
            Database.EnsureCreated();
        }
        public GMallDbContext(DbContextOptions<GMallDbContext> options)
        {

        }

        #region Set
        public DbSet<BrandDO> BrandDO { get; set; }
        public DbSet<BrandPictureDO> BrandPictureDO { get; set; }
        public DbSet<CategoryDO> CategoryDO { get; set; }
        public DbSet<CategoryPictureDO> CategoryPictureDO { get; set; }
        public DbSet<CategoryPropertyDO> CategoryPropertyDO { get; set; }
        public DbSet<CategoryPropertyValueDO> CategoryPropertyValueDO { get; set; }
        public DbSet<PictureDO> PictureDO { get; set; }
        public DbSet<ProductCustomPropertyDO> ProductCustomPropertyDO { get; set; }
        public DbSet<ProductDO> ProductDO { get; set; }
        public DbSet<ProductPictureDO> ProductPictureDO { get; set; }
        public DbSet<ProductPropertyDO> ProductPropertyDO { get; set; }
        public DbSet<ProductSalePropertyDO> ProductSalePropertyDO { get; set; }
        public DbSet<ProductSalePropertyValueDO> ProductSalePropertyValueDO { get; set; }
        public DbSet<ProductSkuDO> ProductSkuDO { get; set; }
        public DbSet<ProductSpecificationDO> ProductSpecificationDO { get; set; }
        public DbSet<ProductSpecificationPropertyDO> ProductSpecificationPropertyDO { get; set; }
        public DbSet<PropertyDO> PropertyDO { get; set; }
        public DbSet<PropertyValueDO> PropertyValueDO { get; set; }
        #endregion
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=.;database=GMallDB;uid=sa;pwd=123456");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Mappting
            modelBuilder.ApplyConfiguration(new BrandDOMapping());
            modelBuilder.ApplyConfiguration(new BrandPictureDOMapping());
            modelBuilder.ApplyConfiguration(new CategoryDOMapping());
            modelBuilder.ApplyConfiguration(new CategoryPictureDOMapping());
            modelBuilder.ApplyConfiguration(new CategoryPropertyDOMapping());
            modelBuilder.ApplyConfiguration(new CategoryPropertyValueDOMapping());
            modelBuilder.ApplyConfiguration(new PictureDOMapping());
            modelBuilder.ApplyConfiguration(new ProductCustomPropertyDOMapping());
            modelBuilder.ApplyConfiguration(new ProductDOMapping());
            modelBuilder.ApplyConfiguration(new ProductPictureDOMapping());
            modelBuilder.ApplyConfiguration(new ProductPropertyDOMapping());
            modelBuilder.ApplyConfiguration(new ProductSalePropertyDOMapping());
            modelBuilder.ApplyConfiguration(new ProductSalePropertyValueDOMapping());
            modelBuilder.ApplyConfiguration(new ProductSkuDOMapping());
            modelBuilder.ApplyConfiguration(new ProductSpecificationDOMapping());
            modelBuilder.ApplyConfiguration(new ProductSpecificationPropertyDOMapping());
            modelBuilder.ApplyConfiguration(new PropertyDOMapping());
            modelBuilder.ApplyConfiguration(new PropertyValueDOMapping());
            #endregion
        }
    }
}
