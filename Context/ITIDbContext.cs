using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_CORE_Project.ITI;
using Microsoft.EntityFrameworkCore;

namespace EF_CORE_Project.Context
{
    public class ITIDbContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=ITI_EF_Core;trusted_connection = true;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().HasMany(x => x.Students)
                                             .WithOne()
                                             .HasForeignKey(x => x.Dep_Id);

            modelBuilder.Entity<Department>().HasMany(x => x.Instructors)
                                             .WithOne()
                                             .HasForeignKey(x => x.Dep_Id)
                                             .OnDelete(DeleteBehavior.NoAction);
           modelBuilder.Entity<Department>().HasOne(x => x.Manager)
                                           .WithOne().HasForeignKey<Department>(x => x.Ins_Id);

            modelBuilder.Entity<Topic>().HasMany(x => x.courses)
                                        .WithOne().HasForeignKey(x => x.Top_Id);
            modelBuilder.Entity<Student_Course>().HasKey(x => new {x.Stud_Id,x.Course_Id});
            modelBuilder.Entity<Course_Instructor>().HasKey(x => new {x.Course_Id,x.Inst_Id});
        }
        public DbSet<Student>Students { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructors> Instructors { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student_Course> Student_Courses { get; set; }
        public DbSet<Course_Instructor> Course_Instructors { get; set; }



    }
}
