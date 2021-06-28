using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Connect
{
    public class Connection : DbContext
    {
        public DbSet<Entities.Beast> Beasts { get; set; }
        public DbSet<Entities.Doctor> Doctors { get; set; }
        public DbSet<Entities.Owner> Owners { get; set; }
        public DbSet<Entities.Services> Services { get; set; }
        public DbSet<Entities.Vaccine> Vaccines { get; set; }
        public DbSet<Entities.Result> Results { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer(@"Data Source = DESKTOP-CNQ430H; Database = VetClinic; Trusted_Connection=True;");
        }
    }
}
