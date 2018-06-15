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
        public DbSet<Samuai> Samuais { get; set; }
        public DbSet<Quote> Quotes { get; set; }
        public DbSet<Batle> Batles { get; set; }
    }
}
