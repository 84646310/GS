using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace GMall.EFCore.Data
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<GMallDbContext>
    {
        public GMallDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<GMallDbContext>();
            optionsBuilder.UseSqlServer("Data Source=.;database=GMallDB;uid=sa;pwd=123456");

            return new GMallDbContext(optionsBuilder.Options);
        }
    }
}
