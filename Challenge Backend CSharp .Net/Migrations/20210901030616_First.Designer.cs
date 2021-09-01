﻿// <auto-generated />
using System;
using Challenge_Backend_CSharp_.Net.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Challenge_Backend_CSharp_.Net.Migrations
{
    [DbContext(typeof(CharactersContext))]
    [Migration("20210901030616_First")]
    partial class First
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Challenge_Backend_CSharp_.Net.Entities.Character", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<float>("Height")
                        .HasColumnType("real");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Story")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("Challenge_Backend_CSharp_.Net.Entities.Genre", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Denomination")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("Challenge_Backend_CSharp_.Net.Entities.Movie", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Area")
                        .HasColumnType("int");

                    b.Property<string>("Denomination")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("GenreID")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Population")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("GenreID");

                    b.ToTable("CMovies");
                });

            modelBuilder.Entity("CharacterMovie", b =>
                {
                    b.Property<int>("CharactersID")
                        .HasColumnType("int");

                    b.Property<int>("MoviesID")
                        .HasColumnType("int");

                    b.HasKey("CharactersID", "MoviesID");

                    b.HasIndex("MoviesID");

                    b.ToTable("CharacterMovie");
                });

            modelBuilder.Entity("Challenge_Backend_CSharp_.Net.Entities.Movie", b =>
                {
                    b.HasOne("Challenge_Backend_CSharp_.Net.Entities.Genre", "Genre")
                        .WithMany("Movies")
                        .HasForeignKey("GenreID");

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("CharacterMovie", b =>
                {
                    b.HasOne("Challenge_Backend_CSharp_.Net.Entities.Character", null)
                        .WithMany()
                        .HasForeignKey("CharactersID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Challenge_Backend_CSharp_.Net.Entities.Movie", null)
                        .WithMany()
                        .HasForeignKey("MoviesID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Challenge_Backend_CSharp_.Net.Entities.Genre", b =>
                {
                    b.Navigation("Movies");
                });
#pragma warning restore 612, 618
        }
    }
}
