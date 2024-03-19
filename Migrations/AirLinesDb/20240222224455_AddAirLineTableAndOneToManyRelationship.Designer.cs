﻿// <auto-generated />
using System;
using EF_CORE_Project.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EF_CORE_Project.Migrations.AirLinesDb
{
    [DbContext(typeof(AirLinesDbContext))]
    [Migration("20240222224455_AddAirLineTableAndOneToManyRelationship")]
    partial class AddAirLineTableAndOneToManyRelationship
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.27")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EF_CORE_Project.AirLines.Aircraft", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AL_ID")
                        .HasColumnType("int");

                    b.Property<string>("Assistant")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Capacity")
                        .HasColumnType("int");

                    b.Property<string>("Host1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Host2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MajPilot")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AL_ID");

                    b.ToTable("Aircrafts");
                });

            modelBuilder.Entity("EF_CORE_Project.AirLines.AirLine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cont_Person")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AirLine");
                });

            modelBuilder.Entity("EF_CORE_Project.AirLines.Aircraft", b =>
                {
                    b.HasOne("EF_CORE_Project.AirLines.AirLine", null)
                        .WithMany("Aircrafts")
                        .HasForeignKey("AL_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EF_CORE_Project.AirLines.AirLine", b =>
                {
                    b.Navigation("Aircrafts");
                });
#pragma warning restore 612, 618
        }
    }
}
