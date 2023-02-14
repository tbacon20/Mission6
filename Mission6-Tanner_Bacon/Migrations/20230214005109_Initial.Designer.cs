﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission6_Tanner_Bacon.Models;

namespace Mission6_Tanner_Bacon.Migrations
{
    [DbContext(typeof(MovieCollectionContext))]
    [Migration("20230214005109_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32");

            modelBuilder.Entity("Mission6_Tanner_Bacon.Models.ApplicationResponse", b =>
                {
                    b.Property<int>("ApplicationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Edited")
                        .HasColumnType("TEXT");

                    b.Property<string>("Lent")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT")
                        .HasMaxLength(25);

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("ApplicationId");

                    b.ToTable("Responses");

                    b.HasData(
                        new
                        {
                            ApplicationId = 1,
                            Category = "Science Fiction",
                            Director = "Christopher Nolan",
                            Edited = "",
                            Lent = "",
                            Notes = "",
                            Rating = "PG-13",
                            Title = "Interstellar",
                            Year = 2014
                        },
                        new
                        {
                            ApplicationId = 2,
                            Category = "Action",
                            Director = "Christopher Nolan",
                            Edited = "",
                            Lent = "",
                            Notes = "",
                            Rating = "PG-13",
                            Title = "Tenet",
                            Year = 2020
                        },
                        new
                        {
                            ApplicationId = 3,
                            Category = "Science Fiction",
                            Director = "Christopher Nolan",
                            Edited = "",
                            Lent = "",
                            Notes = "",
                            Rating = "PG-13",
                            Title = "Inception",
                            Year = 2010
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
