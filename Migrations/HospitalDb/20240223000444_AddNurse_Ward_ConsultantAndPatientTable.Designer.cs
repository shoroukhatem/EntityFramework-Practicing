﻿// <auto-generated />
using EF_CORE_Project.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EF_CORE_Project.Migrations.HospitalDb
{
    [DbContext(typeof(HospitalDbContext))]
    [Migration("20240223000444_AddNurse_Ward_ConsultantAndPatientTable")]
    partial class AddNurse_Ward_ConsultantAndPatientTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.27")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EF_CORE_Project.Hospital.Consultant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Consultants");
                });

            modelBuilder.Entity("EF_CORE_Project.Hospital.Nurse", b =>
                {
                    b.Property<int>("Number")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Number"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Ward_Id")
                        .HasColumnType("int");

                    b.HasKey("Number");

                    b.HasIndex("Ward_Id");

                    b.ToTable("Nurses");
                });

            modelBuilder.Entity("EF_CORE_Project.Hospital.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("DOB")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("EF_CORE_Project.Hospital.Ward", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Nurse_Num")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Nurse_Num")
                        .IsUnique();

                    b.ToTable("Wards");
                });

            modelBuilder.Entity("EF_CORE_Project.Hospital.Nurse", b =>
                {
                    b.HasOne("EF_CORE_Project.Hospital.Ward", "Ward")
                        .WithMany("Nurses")
                        .HasForeignKey("Ward_Id");

                    b.Navigation("Ward");
                });

            modelBuilder.Entity("EF_CORE_Project.Hospital.Ward", b =>
                {
                    b.HasOne("EF_CORE_Project.Hospital.Nurse", "Manager")
                        .WithOne()
                        .HasForeignKey("EF_CORE_Project.Hospital.Ward", "Nurse_Num");

                    b.Navigation("Manager");
                });

            modelBuilder.Entity("EF_CORE_Project.Hospital.Ward", b =>
                {
                    b.Navigation("Nurses");
                });
#pragma warning restore 612, 618
        }
    }
}
