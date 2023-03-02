using AM.ApplicationCore.Domain;
using AM.Infrastructure.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure
{
    public  class AMContexte : DbContext
    {
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<Plane> Planes { get; set; }
        public DbSet<Test2> Tests { get; set; }

        //public DbSet<Staff> Staffs { get; set; }
        //public DbSet<Traveller> Travellers { get; set; }




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source =(localDB)\MSSqlLocalDB; Initial Catalog=ChaimaHadjKacem; Integrated Security=true ");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FlightConfiguration());
        }
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<String>().HaveMaxLength(120); // besh yaaml mappe l bd les prop eli type mteehom string ywaliw fehom 120 caractères
        }


    }
}
