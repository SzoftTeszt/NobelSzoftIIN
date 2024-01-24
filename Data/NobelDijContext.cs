using Microsoft.EntityFrameworkCore;
using NobelDij.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NobelDij.Data
{
    internal class NobelDijContext :DbContext
    {
        public DbSet<Dij> Dijak { get; set; }
        public DbSet<Fajta> Tipusok { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MsSqlLocalDb;Database=NobelKituntetesek;Trusted_Connection=True;");
        }
    }
}
