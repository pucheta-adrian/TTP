﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TTP.Infrastructure.Persistence;

#nullable disable

namespace TTP.Infrastructure.Migrations.ApplicationDb
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231006232709_InitialApplicationDb")]
    partial class InitialApplicationDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.11");

            modelBuilder.Entity("TTP.Domain.Entities.Product", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnOrder(0);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Name = "Lambda Functions",
                            Price = 0.01
                        },
                        new
                        {
                            Id = 2L,
                            Name = "SQS Messages",
                            Price = 0.050000000000000003
                        },
                        new
                        {
                            Id = 3L,
                            Name = "Databases SQL",
                            Price = 0.47999999999999998
                        },
                        new
                        {
                            Id = 4L,
                            Name = "Databases NoSQL",
                            Price = 0.38
                        },
                        new
                        {
                            Id = 5L,
                            Name = "Elastic Cache",
                            Price = 0.11
                        },
                        new
                        {
                            Id = 6L,
                            Name = "Cluster Docker Containers",
                            Price = 1.3700000000000001
                        });
                });
#pragma warning restore 612, 618
        }
    }
}