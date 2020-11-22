using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class AppContext:DbContext
    {
        public AppContext(DbContextOptions<AppContext> options):base(options)
        {

        }

        public DbSet<Student> students { get; set; }

        //创建种子数据
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.CreateSeedData();
            base.OnModelCreating(modelBuilder);
        }
    }
}
