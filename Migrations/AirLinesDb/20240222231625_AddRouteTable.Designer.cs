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
    [Migration("20240222231625_AddRouteTable")]
    partial class AddRouteTable
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
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("AirLines");
                });

            modelBuilder.Entity("EF_CORE_Project.AirLines.Airline_Phones", b =>
                {
                    b.Property<int>("AL_Id")
                        .HasColumnType("int");

                    b.Property<string>("Phones")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("AL_Id", "Phones");

                    b.ToTable("Airlines_Phones");
                });

            modelBuilder.Entity("EF_CORE_Project.AirLines.Emp_Qualifications", b =>
                {
                    b.Property<int>("Emp_Id")
                        .HasColumnType("int");

                    b.Property<string>("Qualifications")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Emp_Id", "Qualifications");

                    b.ToTable("Emp_Qualifications");
                });

            modelBuilder.Entity("EF_CORE_Project.AirLines.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AL_ID")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BD_Day")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BD_Month")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BD_Year")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AL_ID");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("EF_CORE_Project.AirLines.Transaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AL_ID")
                        .HasColumnType("int");

                    b.Property<double?>("Amount")
                        .HasColumnType("float");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AL_ID");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("EF_CORE_Project.AirLines.Aircraft", b =>
                {
                    b.HasOne("EF_CORE_Project.AirLines.AirLine", null)
                        .WithMany("Aircrafts")
                        .HasForeignKey("AL_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EF_CORE_Project.AirLines.Airline_Phones", b =>
                {
                    b.HasOne("EF_CORE_Project.AirLines.AirLine", null)
                        .WithMany("Airline_Phones")
                        .HasForeignKey("AL_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EF_CORE_Project.AirLines.Emp_Qualifications", b =>
                {
                    b.HasOne("EF_CORE_Project.AirLines.Employee", null)
                        .WithMany("EmpQualifications")
                        .HasForeignKey("Emp_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EF_CORE_Project.AirLines.Employee", b =>
                {
                    b.HasOne("EF_CORE_Project.AirLines.AirLine", null)
                        .WithMany("Employees")
                        .HasForeignKey("AL_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EF_CORE_Project.AirLines.Transaction", b =>
                {
                    b.HasOne("EF_CORE_Project.AirLines.AirLine", null)
                        .WithMany("Transactions")
                        .HasForeignKey("AL_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EF_CORE_Project.AirLines.AirLine", b =>
                {
                    b.Navigation("Aircrafts");

                    b.Navigation("Airline_Phones");

                    b.Navigation("Employees");

                    b.Navigation("Transactions");
                });

            modelBuilder.Entity("EF_CORE_Project.AirLines.Employee", b =>
                {
                    b.Navigation("EmpQualifications");
                });
#pragma warning restore 612, 618
        }
    }
}
