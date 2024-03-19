﻿// <auto-generated />
using System;
using EF_CORE_Project.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EF_CORE_Project.Migrations.ITIDb
{
    [DbContext(typeof(ITIDbContext))]
    [Migration("20240222211105_AddManyToManyRelationCourse_Instructor")]
    partial class AddManyToManyRelationCourse_Instructor
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.27")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EF_CORE_Project.ITI.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Top_Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Top_Id");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("EF_CORE_Project.ITI.Course_Instructor", b =>
                {
                    b.Property<int>("Course_Id")
                        .HasColumnType("int");

                    b.Property<int>("Inst_Id")
                        .HasColumnType("int");

                    b.Property<double>("Evaluation")
                        .HasColumnType("float");

                    b.HasKey("Course_Id", "Inst_Id");

                    b.HasIndex("Inst_Id");

                    b.ToTable("Course_Instructors");
                });

            modelBuilder.Entity("EF_CORE_Project.ITI.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Hiring_Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Ins_Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Ins_Id")
                        .IsUnique();

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("EF_CORE_Project.ITI.Instructors", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Bouns")
                        .HasColumnType("float");

                    b.Property<int>("Dep_Id")
                        .HasColumnType("int");

                    b.Property<double>("Hour_Rate")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Salary")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("Dep_Id");

                    b.ToTable("Instructors");
                });

            modelBuilder.Entity("EF_CORE_Project.ITI.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("Dep_Id")
                        .HasColumnType("int");

                    b.Property<string>("FName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Dep_Id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("EF_CORE_Project.ITI.Student_Course", b =>
                {
                    b.Property<int>("Stud_Id")
                        .HasColumnType("int");

                    b.Property<int>("Course_Id")
                        .HasColumnType("int");

                    b.Property<double>("Grade")
                        .HasColumnType("float");

                    b.HasKey("Stud_Id", "Course_Id");

                    b.HasIndex("Course_Id");

                    b.ToTable("Student_Courses");
                });

            modelBuilder.Entity("EF_CORE_Project.ITI.Topic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Topics");
                });

            modelBuilder.Entity("EF_CORE_Project.ITI.Course", b =>
                {
                    b.HasOne("EF_CORE_Project.ITI.Topic", null)
                        .WithMany("courses")
                        .HasForeignKey("Top_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EF_CORE_Project.ITI.Course_Instructor", b =>
                {
                    b.HasOne("EF_CORE_Project.ITI.Course", "Course")
                        .WithMany()
                        .HasForeignKey("Course_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EF_CORE_Project.ITI.Instructors", "Instructors")
                        .WithMany()
                        .HasForeignKey("Inst_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Instructors");
                });

            modelBuilder.Entity("EF_CORE_Project.ITI.Department", b =>
                {
                    b.HasOne("EF_CORE_Project.ITI.Instructors", "Manager")
                        .WithOne()
                        .HasForeignKey("EF_CORE_Project.ITI.Department", "Ins_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Manager");
                });

            modelBuilder.Entity("EF_CORE_Project.ITI.Instructors", b =>
                {
                    b.HasOne("EF_CORE_Project.ITI.Department", null)
                        .WithMany("Instructors")
                        .HasForeignKey("Dep_Id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("EF_CORE_Project.ITI.Student", b =>
                {
                    b.HasOne("EF_CORE_Project.ITI.Department", null)
                        .WithMany("Students")
                        .HasForeignKey("Dep_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EF_CORE_Project.ITI.Student_Course", b =>
                {
                    b.HasOne("EF_CORE_Project.ITI.Course", "Course")
                        .WithMany()
                        .HasForeignKey("Course_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EF_CORE_Project.ITI.Student", "Student")
                        .WithMany()
                        .HasForeignKey("Stud_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("EF_CORE_Project.ITI.Department", b =>
                {
                    b.Navigation("Instructors");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("EF_CORE_Project.ITI.Topic", b =>
                {
                    b.Navigation("courses");
                });
#pragma warning restore 612, 618
        }
    }
}
