﻿// <auto-generated />
using EF_CORE_Project.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EF_CORE_Project.Migrations
{
    [DbContext(typeof(SalesDbContext))]
    [Migration("20240222190158_AddSalesOfficeAndEmployeeTablesWithRelationships")]
    partial class AddSalesOfficeAndEmployeeTablesWithRelationships
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.27")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EF_CORE_Project.Sales.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Off_Number")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Off_Number");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("EF_CORE_Project.Sales.Sales_Office", b =>
                {
                    b.Property<int>("Number")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Number"), 1L, 1);

                    b.Property<int>("EmpId")
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Number");

                    b.HasIndex("EmpId")
                        .IsUnique();

                    b.ToTable("Sales_Offices");
                });

            modelBuilder.Entity("EF_CORE_Project.Sales.Employee", b =>
                {
                    b.HasOne("EF_CORE_Project.Sales.Sales_Office", "Office")
                        .WithMany("Employees")
                        .HasForeignKey("Off_Number")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Office");
                });

            modelBuilder.Entity("EF_CORE_Project.Sales.Sales_Office", b =>
                {
                    b.HasOne("EF_CORE_Project.Sales.Employee", "Manager")
                        .WithOne()
                        .HasForeignKey("EF_CORE_Project.Sales.Sales_Office", "EmpId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Manager");
                });

            modelBuilder.Entity("EF_CORE_Project.Sales.Sales_Office", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
