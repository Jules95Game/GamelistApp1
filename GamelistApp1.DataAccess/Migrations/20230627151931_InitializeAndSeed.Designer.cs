﻿// <auto-generated />
using GamelistApp1.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GamelistApp1.DataAccess.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230627151931_InitializeAndSeed")]
    partial class InitializeAndSeed
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GamelistApp1.Domain.Models.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Developer")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Platform")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.Property<string>("Publisher")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Games");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Wahoo!",
                            Developer = "Nintendo EPD",
                            Platform = "Nintendo Switch",
                            Publisher = "Nintendo",
                            Title = "Super Mario Odyssey"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Yahaha!",
                            Developer = "Nintendo EPD",
                            Platform = "Nintendo Switch",
                            Publisher = "Nintendo",
                            Title = "The Legend of Zelda: Breath of the Wild"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Haiya!",
                            Developer = "HAL Laboratory",
                            Platform = "Nintendo Switch",
                            Publisher = "Nintendo",
                            Title = "Kirby's Return to Dream Land Deluxe"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Hey! Listen!",
                            Developer = "Nintendo EAD",
                            Platform = "Nintendo 64",
                            Publisher = "Nintendo",
                            Title = "The Legend of Zelda: Ocarina of Time"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
