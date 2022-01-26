﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission4.Models;

namespace Mission4.Migrations
{
    [DbContext(typeof(NewMovieContext))]
    [Migration("20220125232157_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("Mission4.Models.MovieResponse", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("DirectorFirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("DirectorLastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT");

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("MovieId");

                    b.ToTable("Responses");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            Category = "Family",
                            DirectorFirstName = "T.C.",
                            DirectorLastName = "Christensen",
                            Edited = false,
                            LentTo = "",
                            Notes = "The music is great",
                            Rating = "PG",
                            Title = "17 Miracles",
                            Year = 2011
                        },
                        new
                        {
                            MovieId = 2,
                            Category = "Family",
                            DirectorFirstName = "Kenneth",
                            DirectorLastName = "Branagh",
                            Edited = false,
                            LentTo = "",
                            Notes = "The music is great",
                            Rating = "PG",
                            Title = "Cinderella",
                            Year = 2015
                        },
                        new
                        {
                            MovieId = 3,
                            Category = "Family",
                            DirectorFirstName = "George",
                            DirectorLastName = "Miller",
                            Edited = false,
                            LentTo = "",
                            Notes = "The music is great",
                            Rating = "PG",
                            Title = "The Man from Snowy River",
                            Year = 1982
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
