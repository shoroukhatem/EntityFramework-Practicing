using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_CORE_Project.Hospital;
using Microsoft.EntityFrameworkCore;
namespace EF_CORE_Project.Context
{
    public class HospitalDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=Hospital;trusted_connection = true;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ward>().HasOne(x => x.Manager)
                                       .WithOne()
                                       .HasForeignKey<Ward>(x => x.Nurse_Num)
                                       .IsRequired(false);
            modelBuilder.Entity<Ward>().HasMany(x=>x.Nurses)
                                        .WithOne(x=>x.Ward)
                                        .HasForeignKey(x=>x.Ward_Id)
                                        .IsRequired(false);
            modelBuilder.Entity<Consultant>().HasMany(x => x.Patients).WithOne()
                                                .HasForeignKey(x => x.Con_Id)
                                                .IsRequired(false); 
            modelBuilder.Entity<Ward>().HasMany(x => x.Patients).WithOne()
                                        .HasForeignKey(x => x.Ward_Id)
                                        .IsRequired(false);
            modelBuilder.Entity<Patient_Con>().HasKey(x=>new { x.Con_Id ,x.Pat_Id});
            modelBuilder.Entity<Drug_Brand>().HasKey(x=>new { x.Code,x.Brand});
            modelBuilder.Entity<Nurse_Drug_Patient>().HasKey(x=>new { x.Pat_Id ,x.Date,x.Time});
           
        }
        public DbSet<Consultant> Consultants { get; set; }  
        public DbSet<Nurse> Nurses { get; set; }
        public DbSet <Patient> Patients { get; set; }
        public DbSet <Ward> Wards { get; set; }
        public DbSet <Patient_Con> patient_Con { get; set; }
        public DbSet <Drug> Drugs { get; set; }
        public DbSet <Drug_Brand> Drug_Brand { get; set; }
        public DbSet <Nurse_Drug_Patient> Nurse_Drug_Patient { get; set; }


    }
}
