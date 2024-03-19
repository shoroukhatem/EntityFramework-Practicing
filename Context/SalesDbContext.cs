using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_CORE_Project.Sales;
using Microsoft.EntityFrameworkCore;

namespace EF_CORE_Project.Context
{
    public class SalesDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=Sales;trusted_connection = true;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sales_Office>().HasKey(x => x.Number);
            modelBuilder.Entity<Sales_Office>().Property(x => x.Number).UseIdentityColumn(1, 1);

            modelBuilder.Entity<Sales_Office>().HasOne(x => x.Manager)
                                                .WithOne()
                                                .HasForeignKey<Sales_Office>(x => x.EmpId);

            modelBuilder.Entity<Sales_Office>().HasMany(x => x.Employees)
                                               .WithOne(x => x.Office)
                                               .HasForeignKey(X => X.Off_Number)
                                               .OnDelete(DeleteBehavior.NoAction)
                                               .IsRequired(false);
            modelBuilder.Entity<Sales_Office>().HasMany(x => x.properties)
                                               .WithOne(x => x.Office)
                                               .HasForeignKey(X => X.Off_Number)
                                               .OnDelete(DeleteBehavior.NoAction)
                                               .IsRequired(true);
            modelBuilder.Entity<Prop_Owner>().HasKey(x => new { x.Own_Id, x.Prop_Id });



        }
        public DbSet<Sales_Office> Sales_Offices { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Property> properties { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Prop_Owner> Prop_Owner { get; set; }

    }
}
