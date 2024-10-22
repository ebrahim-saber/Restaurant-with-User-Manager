﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Resturant_Pro.Data;

#nullable disable

namespace Resturant_Pro.Migrations
{
    [DbContext(typeof(ApDbContext))]
    [Migration("20231101110816_SeedCategoryTab")]
    partial class SeedCategoryTab
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Resturant_Pro.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Displayorder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Displayorder = 1,
                            Name = "Action"
                        },
                        new
                        {
                            Id = 2,
                            Displayorder = 2,
                            Name = "Scifi"
                        },
                        new
                        {
                            Id = 3,
                            Displayorder = 3,
                            Name = "History"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
