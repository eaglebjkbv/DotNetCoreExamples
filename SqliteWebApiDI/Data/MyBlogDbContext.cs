using SqliteWebApiDI.Models;
using Microsoft.EntityFrameworkCore;

namespace SqliteWebApiDI.Data
{
    public class MyBlogDbContext : DbContext
    {
        public MyBlogDbContext(DbContextOptions<MyBlogDbContext> options)
          : base(options)
        { }

        public DbSet<Blog> Blogs { get; set; }
        // protected override void OnConfiguring(DbContextOptionsBuilder options)
           // => options.UseSqlite("Data Source=blog.db");
    }
}