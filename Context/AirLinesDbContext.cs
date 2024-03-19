using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_CORE_Project.AirLines;
using Microsoft.EntityFrameworkCore;
namespace EF_CORE_Project.Context
{
    public class AirLinesDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=AirLines;trusted_connection = true;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AirLine>().HasMany(x => x.Aircrafts)
                                          .WithOne()
                                          .HasForeignKey(x=>x.AL_ID)
                                          .IsRequired(true);
            modelBuilder.Entity<AirLine>().HasMany(x => x.Airline_Phones)
                                          .WithOne()
                                          .HasForeignKey(x=>x.AL_Id)
                                          .IsRequired(true);
            modelBuilder.Entity<Airline_Phones>().HasKey(x => new {x.AL_Id,x.Phones});

            modelBuilder.Entity<AirLine>().HasMany(x => x.Transactions)
                                         .WithOne()
                                         .HasForeignKey(x => x.AL_ID)
                                         .IsRequired(true);
            modelBuilder.Entity<AirLine>().HasMany(x => x.Employees)
                                         .WithOne()
                                         .HasForeignKey(x => x.AL_ID)
                                         .IsRequired(true);
            modelBuilder.Entity<Employee>().HasMany(x=>x.EmpQualifications).WithOne()
                                           .HasForeignKey(x=>x.Emp_Id)
                                           .IsRequired(true);
            modelBuilder.Entity<Emp_Qualifications>().HasKey(x => new { x.Emp_Id, x.Qualifications });
            modelBuilder.Entity<Aircraft_Routes>().HasKey(x => new { x.Route_Id, x.AC_Id,x.Departure });
           
        }
        public DbSet<Aircraft> Aircrafts { get; set; }
        public DbSet<AirLine> AirLines { get; set; }
        public DbSet<Airline_Phones> Airlines_Phones { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Emp_Qualifications> Emp_Qualifications { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<Aircraft_Routes> Aircraft_Routes { get; set; }
        
    }
}
