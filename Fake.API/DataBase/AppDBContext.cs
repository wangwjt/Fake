using Fake.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Fake.API.DataBase
{
    // 需要继承EntityFrameworkCore中的DbContext
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options):base(options)
        {
            
        }

        // 指明那些模型需要映射到数据库中 使用DBSet进行模型的映射
        public DbSet<TouristRoute> TouristRoutes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // 实体映射到表名
            modelBuilder.Entity<TouristRoute>().ToTable("tourist_route");
            base.OnModelCreating(modelBuilder);
        }
    }
}
