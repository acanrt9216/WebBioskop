﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebBioskop.Data;

namespace WebBioskop.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebBioskop.Models.Genre", b =>
                {
                    b.Property<int>("genreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("id")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("genreId");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("WebBioskop.Models.Movie", b =>
                {
                    b.Property<int>("movieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("adult")
                        .HasColumnType("bit");

                    b.Property<string>("backdrop_path")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("genre_ids")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("id")
                        .HasColumnType("int");

                    b.Property<string>("original_language")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("original_title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("overview")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("poster_path")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("release_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("video")
                        .HasColumnType("bit");

                    b.Property<double>("vote_average")
                        .HasColumnType("float");

                    b.Property<int>("vote_count")
                        .HasColumnType("int");

                    b.HasKey("movieId");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("WebBioskop.Models.Serie", b =>
                {
                    b.Property<int>("serieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("backdrop_path")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("first_air_date")
                        .HasColumnType("datetime2");

                    b.Property<int>("id")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("original_language")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("original_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("overview")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("popularity")
                        .HasColumnType("float");

                    b.Property<string>("poster_path")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("vote_average")
                        .HasColumnType("float");

                    b.Property<int>("vote_count")
                        .HasColumnType("int");

                    b.HasKey("serieId");

                    b.ToTable("Series");
                });
#pragma warning restore 612, 618
        }
    }
}
