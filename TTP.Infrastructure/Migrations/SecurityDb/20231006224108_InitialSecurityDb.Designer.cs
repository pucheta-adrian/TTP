﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TTP.Infrastructure.Persistence;

#nullable disable

namespace TTP.Infrastructure.Migrations.SecurityDb
{
    [DbContext(typeof(SecurityDbContext))]
    [Migration("20231006224108_InitialSecurityDb")]
    partial class InitialSecurityDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.11");

            modelBuilder.Entity("TTP.Domain.Entities.Organization", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnOrder(0);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SlugTenant")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Organizations");
                });

            modelBuilder.Entity("TTP.Domain.Entities.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnOrder(0);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Email = "pucheta.adrian@gmail.com",
                            Password = "vVYqRwo7PqNr4x1paRSf8QYrf6W4wsXQJzMlMOoYG0xn3n3wXpV54EZfn3vmUQ19"
                        },
                        new
                        {
                            Id = 2L,
                            Email = "zephirotube@gmail.com",
                            Password = "vVYqRwo7PqNr4x1paRSf8QYrf6W4wsXQJzMlMOoYG0xn3n3wXpV54EZfn3vmUQ19"
                        });
                });

            modelBuilder.Entity("TTP.Domain.Entities.UserOrganization", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnOrder(0);

                    b.Property<long>("OrganizationId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("OrganizationId");

                    b.HasIndex("UserId");

                    b.ToTable("UserOrganizations");
                });

            modelBuilder.Entity("TTP.Domain.Entities.UserOrganization", b =>
                {
                    b.HasOne("TTP.Domain.Entities.Organization", "Organization")
                        .WithMany()
                        .HasForeignKey("OrganizationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TTP.Domain.Entities.User", "User")
                        .WithMany("UserOrganizations")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Organization");

                    b.Navigation("User");
                });

            modelBuilder.Entity("TTP.Domain.Entities.User", b =>
                {
                    b.Navigation("UserOrganizations");
                });
#pragma warning restore 612, 618
        }
    }
}