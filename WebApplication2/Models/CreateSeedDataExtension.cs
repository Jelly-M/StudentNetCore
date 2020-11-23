using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace WebApplication2.Models
{
    public static class CreateSeedDataExtension
    {
        public static void CreateSeedData(this ModelBuilder builder)
        {
            builder.Entity<Student>().HasData(
                new Student()
                {
                    Id = 1,
                    Name = "张三",
                    Gread = ClassNameEnum.FirstGread,
                    Email = "97202766@qq.com"

                },
               new Student()
               {
                   Id = 2,
                   Name = "张x三",
                   Gread = ClassNameEnum.FirstGread,
                   Email = "97202766@qq.com"

               },
                new Student()
                {
                    Id = 3,
                    Name = "x三",
                    Gread = ClassNameEnum.FirstGread,
                    Email = "97202766@qq.com"

                }
               );
        }
    }
}
