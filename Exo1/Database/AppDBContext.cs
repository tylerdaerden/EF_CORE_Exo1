using Exo1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo1.Database
{
    public class AppDBContext : DbContext
    {
        public DbSet<Film> Films { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //connection string poour VDI TFTIC 👇👇👇
            //optionsBuilder.UseSqlServer(@"Data Source=FORMA-VDI303\TFTIC;Initial Catalog=Exo_01_Film;Integrated Security=True");
            //connection string pour ma tour 
            optionsBuilder.UseSqlServer(@"Data Source=TOURPCDANY\DATAVIZ;Initial Catalog=Exo_01_Film;Integrated Security=True");

        }


        #region Film

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Film>()
                .ToTable("Film");
            modelBuilder.Entity<Film>()
                .HasIndex(f => f.ID);
            modelBuilder.Entity<Film>()
                .Property(f => f.ID)
                .HasColumnName("ID")
                .ValueGeneratedOnAdd()
                .IsRequired();
            modelBuilder.Entity<Film>()
                .Property(f => f.Title)
                .HasColumnName("Title")
                .HasMaxLength(100)
                .IsRequired();
            modelBuilder.Entity<Film>()
                .HasIndex(f=>f.Title)
                .IsUnique();
            modelBuilder.Entity<Film>()
                .Property(f=>f.DateDeSortie)
                .HasColumnName("AnnéeDeSortie")
                .HasDefaultValue(DateTime.MinValue)
                .IsRequired();
            modelBuilder.Entity<Film>()
                .Property(f=>f.Director)
                .HasColumnName("Realisateur")
                .HasMaxLength(100)
                .IsRequired();
            modelBuilder.Entity<Film>()
                .Property(f=>f.MainActor)
                .HasColumnName("Acteur.e Principal.e")
                .HasMaxLength (100)
                .IsRequired();
            modelBuilder.Entity<Film>()
                .Property(f => f.GenreFilm)
                .HasColumnName("Genre")
                .HasMaxLength(100)
                .IsRequired();             

        }


        #endregion
    }
}
