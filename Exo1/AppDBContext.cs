using Exo1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo1
{
    public class AppDBContext : DbContext
    {
        public DbSet<Film> Films { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=FORMA-VDI303\TFTIC;Initial Catalog=Exo_01_Film;Integrated Security=True");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }


    }
}
