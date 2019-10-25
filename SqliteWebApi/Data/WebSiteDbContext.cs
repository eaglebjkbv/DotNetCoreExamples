using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using SqliteWebApi.Models;


namespace SqliteWebApi.Data
{
    public class WebSiteDbContext : DbContext
    {
        
        public DbSet<WebSite> WebSites  { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite("Data Source=websites.db");
    }

}
