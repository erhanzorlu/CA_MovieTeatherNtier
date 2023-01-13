﻿// <auto-generated />
using System;
using Dal.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Dal.Migrations
{
    [DbContext(typeof(MovieTheaterDbContext))]
    partial class MovieTheaterDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Dal.Entity.Category", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Dal.Entity.Movie", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Duration")
                        .HasColumnType("float");

                    b.Property<string>("MovieName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("Dal.Entity.MovieAndCategory", b =>
                {
                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.HasKey("MovieId", "CategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("MoviesAndCategories");
                });

            modelBuilder.Entity("Dal.Entity.Saloon", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<string>("SaloonName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Saloons");
                });

            modelBuilder.Entity("Dal.Entity.Session", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("SessionName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Sessions");
                });

            modelBuilder.Entity("Dal.Entity.Theater", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("MovieID")
                        .HasColumnType("int");

                    b.Property<int>("SaloonID")
                        .HasColumnType("int");

                    b.Property<int>("SessionID")
                        .HasColumnType("int");

                    b.Property<int>("WeekID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("MovieID");

                    b.HasIndex("SaloonID");

                    b.HasIndex("SessionID");

                    b.HasIndex("WeekID");

                    b.ToTable("Theaters");
                });

            modelBuilder.Entity("Dal.Entity.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Dal.Entity.Week", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("FirstDay")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LastDay")
                        .HasColumnType("datetime2");

                    b.Property<string>("WhichWeek")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Weeks");
                });

            modelBuilder.Entity("Dal.Entity.MovieAndCategory", b =>
                {
                    b.HasOne("Dal.Entity.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dal.Entity.Movie", "Movie")
                        .WithMany()
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("Dal.Entity.Theater", b =>
                {
                    b.HasOne("Dal.Entity.Movie", "Movie")
                        .WithMany("Theaters")
                        .HasForeignKey("MovieID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dal.Entity.Saloon", "Saloon")
                        .WithMany("Theaters")
                        .HasForeignKey("SaloonID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dal.Entity.Session", "Session")
                        .WithMany("Theaters")
                        .HasForeignKey("SessionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dal.Entity.Week", "Week")
                        .WithMany("Theaters")
                        .HasForeignKey("WeekID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");

                    b.Navigation("Saloon");

                    b.Navigation("Session");

                    b.Navigation("Week");
                });

            modelBuilder.Entity("Dal.Entity.Movie", b =>
                {
                    b.Navigation("Theaters");
                });

            modelBuilder.Entity("Dal.Entity.Saloon", b =>
                {
                    b.Navigation("Theaters");
                });

            modelBuilder.Entity("Dal.Entity.Session", b =>
                {
                    b.Navigation("Theaters");
                });

            modelBuilder.Entity("Dal.Entity.Week", b =>
                {
                    b.Navigation("Theaters");
                });
#pragma warning restore 612, 618
        }
    }
}