﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NekoQOLWebAPI.Context;

#nullable disable

namespace NekoQOLWebAPI.Migrations
{
    [DbContext(typeof(NekoDbContext))]
    [Migration("20220401041900_IFIXEDSHITTHANKGOD")]
    partial class IFIXEDSHITTHANKGOD
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.3");

            modelBuilder.Entity("NekoQOLWebAPI.Entities.Cape", b =>
                {
                    b.Property<string>("CapeId")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("HypixelPlayerId")
                        .HasColumnType("TEXT");

                    b.HasKey("CapeId");

                    b.HasIndex("HypixelPlayerId");

                    b.ToTable("Capes");
                });

            modelBuilder.Entity("NekoQOLWebAPI.Entities.HypixelPlayer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("HypixelPlayers");
                });

            modelBuilder.Entity("NekoQOLWebAPI.Entities.Cape", b =>
                {
                    b.HasOne("NekoQOLWebAPI.Entities.HypixelPlayer", null)
                        .WithMany("Capes")
                        .HasForeignKey("HypixelPlayerId");
                });

            modelBuilder.Entity("NekoQOLWebAPI.Entities.HypixelPlayer", b =>
                {
                    b.Navigation("Capes");
                });
#pragma warning restore 612, 618
        }
    }
}
