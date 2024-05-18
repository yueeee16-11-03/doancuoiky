﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using dona.Models;

#nullable disable

namespace dona.Migrations
{
    [DbContext(typeof(Datacontext))]
    [Migration("20240517124433_Addchange")]
    partial class Addchange
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("dona.Model.viewPostMenu", b =>
                {
                    b.Property<long>("PostID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("PostID"));

                    b.Property<string>("Abstract")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contents")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Images")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("MenuID")
                        .HasColumnType("int");

                    b.Property<string>("MenuName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PostOrder")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("createted_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("link")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PostID");

                    b.HasIndex("MenuID");

                    b.ToTable("viewPostMenu");

                    b.HasData(
                        new
                        {
                            PostID = 1L,
                            Abstract = "TFT UPDATE VERISON ",
                            Contents = "With 14.10 we asked ourselves, “What's not working?” and after reworking Lissandra, nerfing a few overperformers, and making Prismatic Orbs feel more like rare high rolls, we set out to make the not working stuff, well… work better.",
                            Images = "Image/anh1.jpg",
                            IsActive = true,
                            MenuID = 7,
                            MenuName = "Game UpDate",
                            PostOrder = 1,
                            Title = "TEAMFIGHT TACTICS PATCH 14.10 NOTES",
                            author = "oai",
                            createted_Date = new DateTime(2024, 5, 10, 8, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            PostID = 2L,
                            Abstract = "We have quite a bit of stuff dropping in patch 14.10 ",
                            Contents = "We have quite a bit of stuff dropping in patch 14.10: Split 1 end and Split 2 start details",
                            Images = "Image/anh2.jpg",
                            IsActive = true,
                            MenuID = 7,
                            MenuName = "Game UpDate",
                            PostOrder = 2,
                            Title = "PATCH 14.10 NOTES",
                            author = "oai",
                            createted_Date = new DateTime(2024, 5, 10, 10, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            PostID = 3L,
                            Images = "Image/anh3.jpg",
                            IsActive = true,
                            MenuID = 8,
                            MenuName = "EsPorts",
                            PostOrder = 3,
                            Title = "STAYING THE COURSE |MSI 2024",
                            author = "oai",
                            createted_Date = new DateTime(2024, 5, 10, 11, 0, 0, 0, DateTimeKind.Unspecified),
                            link = "https://www.youtube.com/watch?v=oJl_MKDUHqU"
                        },
                        new
                        {
                            PostID = 4L,
                            Images = "Image/anh4.jpg",
                            IsActive = true,
                            MenuID = 8,
                            MenuName = "EsPorts",
                            PostOrder = 4,
                            Title = "TOP 5 PLAYS|BRACKET STAGE WK1",
                            author = "oai",
                            createted_Date = new DateTime(2024, 5, 10, 13, 0, 0, 0, DateTimeKind.Unspecified),
                            link = "https://www.youtube.com/watch?v=8rPhx_W6YDE"
                        },
                        new
                        {
                            PostID = 5L,
                            Abstract = "In the beginning, the First Star gave birth to the universe and all life",
                            Contents = " To protect its creations and ensure the cycle of life would continue for eternity, the First Star entrusted individuals iron-willed and pure of heart with fragments of its essence—starlight—as protectors of the universe throughout the ages.",
                            Images = "Image/anh5.jpg",
                            IsActive = true,
                            MenuID = 9,
                            MenuName = "Lore",
                            PostOrder = 5,
                            Title = "PREVIOUSLY ON STAR GUARDIAN",
                            author = "oai",
                            createted_Date = new DateTime(2024, 5, 10, 13, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            PostID = 6L,
                            Abstract = "Camavor is a brutal land with a bloody legacy",
                            Contents = " Kalista seeks to change that. When her young and narcissistic uncle, Viego, becomes king she vows to temper his destructive instincts as his loyal confidant, advisor, and military general.",
                            Images = "Image/anh6.png",
                            IsActive = true,
                            MenuID = 9,
                            MenuName = "Lore",
                            PostOrder = 6,
                            Title = "A LEAGUE OF LEGENDS NOVEL",
                            author = "oai",
                            createted_Date = new DateTime(2024, 5, 10, 14, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            PostID = 7L,
                            Abstract = "There’s a lot going on for Pride this year across all our games",
                            Contents = "Pride content hits the Rift with Patch 14.11 and is available until Patch 14.12’s conclusion. The event brings a new mission and Pride Emote, “United,” featuring Twisted Fate and Neeko, as well as returning Pride emotes for 1 Blue Essence each—essence-ially free!",
                            Images = "Image/anh7.jpg",
                            IsActive = true,
                            MenuID = 10,
                            MenuName = "Community",
                            PostOrder = 7,
                            Title = "CELEBRATE PRIDE 2024: LEAGUE AND TFT",
                            author = "oai",
                            createted_Date = new DateTime(2024, 5, 10, 15, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            PostID = 8L,
                            Abstract = "Calling all cosplayers, fan artists, and creators of all kinds",
                            Contents = "Calling all cosplayers, fan artists, and creators of all kinds! We've got a gallery of reference images for the champions featured in our latest cinematic",
                            Images = "Image/anh8.jpg",
                            IsActive = true,
                            MenuID = 10,
                            MenuName = "Community",
                            PostOrder = 8,
                            Title = "STILL HERE REFERENCE MATERIALS",
                            author = "oai",
                            createted_Date = new DateTime(2024, 5, 10, 16, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            PostID = 9L,
                            Images = "Image/anh9.jpg",
                            IsActive = true,
                            MenuID = 6,
                            MenuName = "Riot Games",
                            PostOrder = 9,
                            Title = "THE MAGESEEKER : A LEAGUE OF  LEGENDS STORY GAMEPLAY",
                            author = "oai",
                            createted_Date = new DateTime(2024, 5, 10, 17, 10, 0, 0, DateTimeKind.Unspecified),
                            link = "https://www.youtube.com/watch?v=-KHMMMHvDdM"
                        },
                        new
                        {
                            PostID = 10L,
                            Images = "Image/anh10.jpg",
                            IsActive = true,
                            MenuID = 6,
                            MenuName = "Riot Games",
                            PostOrder = 10,
                            Title = "RIOT FORGE GAMES 2023|THE YEAR AHEAD",
                            author = "oai",
                            createted_Date = new DateTime(2024, 5, 10, 17, 11, 0, 0, DateTimeKind.Unspecified),
                            link = "https://www.youtube.com/watch?v=n66QyujLXyg"
                        });
                });

            modelBuilder.Entity("dona.Models.tblMenu", b =>
                {
                    b.Property<int>("MenuID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MenuID"));

                    b.Property<string>("ActionName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CotrollerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("Levers")
                        .HasColumnType("int");

                    b.Property<string>("MenuName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MenuOrder")
                        .HasColumnType("int");

                    b.Property<int>("ParentID")
                        .HasColumnType("int");

                    b.Property<int>("Position")
                        .HasColumnType("int");

                    b.HasKey("MenuID");

                    b.ToTable("tblMenu");

                    b.HasData(
                        new
                        {
                            MenuID = 1,
                            IsActive = true,
                            Levers = 1,
                            MenuName = "Home",
                            MenuOrder = 1,
                            ParentID = 0,
                            Position = 1
                        },
                        new
                        {
                            MenuID = 2,
                            IsActive = true,
                            Levers = 1,
                            MenuName = "Game",
                            MenuOrder = 2,
                            ParentID = 0,
                            Position = 1
                        },
                        new
                        {
                            MenuID = 3,
                            IsActive = true,
                            Levers = 1,
                            MenuName = "Champions",
                            MenuOrder = 3,
                            ParentID = 0,
                            Position = 1
                        },
                        new
                        {
                            MenuID = 4,
                            IsActive = true,
                            Levers = 1,
                            MenuName = "New",
                            MenuOrder = 4,
                            ParentID = 0,
                            Position = 1
                        },
                        new
                        {
                            MenuID = 5,
                            IsActive = true,
                            Levers = 1,
                            MenuName = "About as",
                            MenuOrder = 6,
                            ParentID = 0,
                            Position = 1
                        },
                        new
                        {
                            MenuID = 6,
                            IsActive = true,
                            Levers = 2,
                            MenuName = "Riot Games",
                            MenuOrder = 1,
                            ParentID = 4,
                            Position = 1
                        },
                        new
                        {
                            MenuID = 7,
                            IsActive = true,
                            Levers = 2,
                            MenuName = "Game UpDate",
                            MenuOrder = 2,
                            ParentID = 4,
                            Position = 1
                        },
                        new
                        {
                            MenuID = 8,
                            IsActive = true,
                            Levers = 2,
                            MenuName = "EsPorts",
                            MenuOrder = 3,
                            ParentID = 4,
                            Position = 1
                        },
                        new
                        {
                            MenuID = 9,
                            IsActive = true,
                            Levers = 2,
                            MenuName = "Lore",
                            MenuOrder = 4,
                            ParentID = 4,
                            Position = 1
                        },
                        new
                        {
                            MenuID = 10,
                            IsActive = true,
                            Levers = 2,
                            MenuName = "Community",
                            MenuOrder = 5,
                            ParentID = 4,
                            Position = 1
                        },
                        new
                        {
                            MenuID = 11,
                            IsActive = true,
                            Levers = 2,
                            MenuName = "Merch",
                            MenuOrder = 6,
                            ParentID = 4,
                            Position = 1
                        });
                });

            modelBuilder.Entity("dona.Model.viewPostMenu", b =>
                {
                    b.HasOne("dona.Models.tblMenu", "Menu")
                        .WithMany()
                        .HasForeignKey("MenuID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Menu");
                });
#pragma warning restore 612, 618
        }
    }
}
