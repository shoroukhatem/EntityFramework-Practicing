using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_CORE_Project.Music;
using Microsoft.EntityFrameworkCore;
namespace EF_CORE_Project.Context
{
    public class MusicianDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=MusicianDB;trusted_connection = true;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
         {
             modelBuilder.Entity<Musician>().HasMany(x => x.Albums)
                                             .WithOne(x => x.Musician)
                                             .HasForeignKey(x => x.Mus_Id)
                                             .IsRequired(false);
             modelBuilder.Entity<Mus_song>().HasKey(x => new { x.Mus_Id ,x.Song_Title});
             modelBuilder.Entity<Mus_Instrument>().HasKey(x => new { x.Mus_Id ,x.Inst_Name});
         }
         public DbSet<Musician> Musicians { get; set; }
         public DbSet<Instrument> Instruments { get; set; }
         public DbSet<Album> Albums { get; set; }
         public DbSet<Song> Song { get; set; }
         public DbSet<Album_Song> Album_Song { get; set; }
         public DbSet<Mus_song> Mus_Songs { get; set; }
         public DbSet<Mus_Instrument> Mus_Instruments { get; set; }
        
    }
}
