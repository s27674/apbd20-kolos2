﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using kolos2.Data;

#nullable disable

namespace kolos2.Migrations
{
    [DbContext(typeof(ItemsContext))]
    partial class ItemsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("kolos2.Models.Backpacks", b =>
                {
                    b.Property<int>("CharacterId")
                        .HasColumnType("int");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.HasKey("CharacterId", "ItemId");

                    b.HasIndex("ItemId");

                    b.ToTable("Backpack");

                    b.HasData(
                        new
                        {
                            CharacterId = 1,
                            ItemId = 1,
                            Amount = 11
                        },
                        new
                        {
                            CharacterId = 2,
                            ItemId = 2,
                            Amount = 22
                        });
                });

            modelBuilder.Entity("kolos2.Models.CharacterTitles", b =>
                {
                    b.Property<int>("CharacterId")
                        .HasColumnType("int");

                    b.Property<int>("TitelsId")
                        .HasColumnType("int");

                    b.Property<DateTime>("AcquiredAt")
                        .HasColumnType("datetime2");

                    b.HasKey("CharacterId", "TitelsId");

                    b.HasIndex("TitelsId");

                    b.ToTable("Character_titels");

                    b.HasData(
                        new
                        {
                            CharacterId = 1,
                            TitelsId = 1,
                            AcquiredAt = new DateTime(2022, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            CharacterId = 2,
                            TitelsId = 2,
                            AcquiredAt = new DateTime(2021, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("kolos2.Models.Characters", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CurrentWeight")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)");

                    b.Property<int>("MaxWeight")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Character");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CurrentWeight = 14,
                            FirstName = "FirstName1",
                            LastName = "LastName1",
                            MaxWeight = 40
                        },
                        new
                        {
                            Id = 2,
                            CurrentWeight = 15,
                            FirstName = "FirstName2",
                            LastName = "LastName12",
                            MaxWeight = 50
                        });
                });

            modelBuilder.Entity("kolos2.Models.Items", b =>
                {
                    b.Property<int>("IdItems")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdItems"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Weight")
                        .HasColumnType("int");

                    b.HasKey("IdItems");

                    b.ToTable("Item");

                    b.HasData(
                        new
                        {
                            IdItems = 1,
                            Name = "ItemName1",
                            Weight = 0
                        },
                        new
                        {
                            IdItems = 2,
                            Name = "ItemName2",
                            Weight = 0
                        });
                });

            modelBuilder.Entity("kolos2.Models.Titles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Title");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "TitlesName1"
                        },
                        new
                        {
                            Id = 2,
                            Name = "TitlesName2"
                        });
                });

            modelBuilder.Entity("kolos2.Models.Backpacks", b =>
                {
                    b.HasOne("kolos2.Models.Characters", "Character")
                        .WithMany("Backpack")
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("kolos2.Models.Items", "Item")
                        .WithMany("Backpack")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Character");

                    b.Navigation("Item");
                });

            modelBuilder.Entity("kolos2.Models.CharacterTitles", b =>
                {
                    b.HasOne("kolos2.Models.Characters", "Character")
                        .WithMany("CharacterTitels")
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("kolos2.Models.Titles", "Title")
                        .WithMany("CharacterTitels")
                        .HasForeignKey("TitelsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Character");

                    b.Navigation("Title");
                });

            modelBuilder.Entity("kolos2.Models.Characters", b =>
                {
                    b.Navigation("Backpack");

                    b.Navigation("CharacterTitels");
                });

            modelBuilder.Entity("kolos2.Models.Items", b =>
                {
                    b.Navigation("Backpack");
                });

            modelBuilder.Entity("kolos2.Models.Titles", b =>
                {
                    b.Navigation("CharacterTitels");
                });
#pragma warning restore 612, 618
        }
    }
}
