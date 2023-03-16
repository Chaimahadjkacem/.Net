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
       //public DbSet<Test2> Tests { get; set; }

        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Traveller> Travellers { get; set; }

        //lezem kol classe naamlelha Dbset mteeha besh naamlelha map fel BD

        public DbSet<Seat> Seats { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

       



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseSqlServer(@"Data Source =(localDB)\MSSqlLocalDB; Initial Catalog=ChaimaHadjKacem; Integrated Security=true ");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           // modelBuilder.ApplyConfiguration(new FlightConfiguration()); // khater nahna naamlou f tpt kol tableau wahdou !!
            modelBuilder.ApplyConfiguration(new PassengerConfiguration()); // lezem nzidha
            modelBuilder.Entity<Passenger>().ToTable("Passengers");// besh nconfiguriw passenger o nbaloulha esmha (tpt)
            modelBuilder.Entity<Traveller>().ToTable("Travellers");// kifkif (tpt)
            modelBuilder.Entity<Staff>().ToTable("Staffs");// tpt ( kol wahda entité tableau mteeha )
            modelBuilder.ApplyConfiguration(new TicketConfiguration());

            //naayet lel classes de configuration 
            modelBuilder.ApplyConfiguration(new SeatConfiguration());
            modelBuilder.ApplyConfiguration(new ReservationConfiguration());


        }
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            //lkol eli type mteehom string mapper dans des colones var char avec longueur 120
            configurationBuilder.Properties<String>().HaveMaxLength(120); // besh yaaml mappe l bd les prop eli type mteehom string ywaliw fehom 120 caractères
            //ensemble d proprietie de meme type -> 
            configurationBuilder.Properties<DateTime>().HaveColumnType("date"); // type sql
            // en reel avec 2 chiffre avant le virgule et 3 chiffre après le virgule
            //configurationBuilder.Properties<Double>().HaveColumnType("real").HavePrecision(2, 3);

        }


    }
}
