﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication2.Models;

namespace WebApplication2.Migrations
{
    [DbContext(typeof(AppContext))]
    partial class AppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplication2.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<int>("Gread");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("PhotePath");

                    b.HasKey("Id");

                    b.ToTable("students");

                    b.HasData(
                        new { Id = 1, Email = "97202766@qq.com", Gread = 1, Name = "张三" },
                        new { Id = 2, Email = "97202766@qq.com", Gread = 1, Name = "张x三" },
                        new { Id = 3, Email = "97202766@qq.com", Gread = 1, Name = "x三" }
                    );
                });
#pragma warning restore 612, 618
        }
    }
}
