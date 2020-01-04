using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleNews.Models
{
    public class NewsDbContext : DbContext
    {
        public NewsDbContext(DbContextOptions options)
            :base(options) {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<News>().Property(u => u.Tags).HasDefaultValue("");
            modelBuilder.Entity<News>().Property(u => u.Title).IsRequired();
        }
        public DbSet<News> NewsTable { get; set; }
    }
}
