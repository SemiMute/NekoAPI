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
    [Migration("20220401014747_HypixelPlayerUpdate")]
    partial class HypixelPlayerUpdate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.3");

            modelBuilder.Entity("NekoQOLWebAPI.Entities.Cape", b =>
                {
                    b.Property<string>("CapeId")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("HypixelPlayerID")
                        .HasColumnType("TEXT");

                    b.HasKey("CapeId");

                    b.HasIndex("HypixelPlayerID");

                    b.ToTable("Capes");
                });

            modelBuilder.Entity("NekoQOLWebAPI.Entities.HypixelPlayer", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("HypixelPlayers");
                });

            modelBuilder.Entity("NekoQOLWebAPI.Entities.Cape", b =>
                {
                    b.HasOne("NekoQOLWebAPI.Entities.HypixelPlayer", null)
                        .WithMany("capes")
                        .HasForeignKey("HypixelPlayerID");
                });

            modelBuilder.Entity("NekoQOLWebAPI.Entities.HypixelPlayer", b =>
                {
                    b.Navigation("capes");
                });
#pragma warning restore 612, 618
        }
    }
}
