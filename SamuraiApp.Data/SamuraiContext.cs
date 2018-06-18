using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SamuraiApp.Domain;

namespace SamuraiApp.Data
{
    public class SamuraiContext : DbContext
    {
        public DbSet<Samurai> Samuais { get; set; }
        public DbSet<Quote> Quotes { get; set; }
        public DbSet<Battle> Batles { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=(localdb)\\mssqllocaldb; Database=SamuraiApp; Trusted_Connection = True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SamuraiBattle>().HasKey(x => new {x.SamuraiId, x.BattleId,});
            base.OnModelCreating(modelBuilder);
        }
    }
}
