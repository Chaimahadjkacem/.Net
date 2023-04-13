using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using AM.ApplicationCore.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Service
{
    public class ServicePlane : Service<Plane>, IServicePlane
    {
        public ServicePlane(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public void DeletePlanes()
        {
            //andi condtion nhot where o dima nektbou expression lampda
            var planes = GetAll().Where(p => (DateTime.Now - p.ManufactureDate).TotalDays < 3650);// somme des nombres de jours en 10 ans 3650
            // pour supprimer ces planes qui ont deja 10 ans 
            foreach(var plane in planes) 
            {
                Delete(plane);
            }
            // besh nfasakh m base de donnee lezem nhot Commit() et de preference baad foreach
            Commit();

            // Ou bien nekhdem b delete hethy 

            //Delete(DateTime.Now - p.ManufactureDate).TotalDays < 3650);
            //Commit();


        }

        public IList<Flight> GetFlights(int n)
        {
            //eli aandou ekher id howa ekher wehed tzed 
            return GetAll().OrderBy(p=>p.PlaneId).TakeLast(n).SelectMany(p=> p.Flights).OrderBy(p=>p.FlightDate).ToList();

            // si descendant Take kahw + OrderByDescending
            // return GetAll().OrderByDescending(p => p.PlaneId).Take(n).SelectMany(p => p.Flights).OrderBy(p => p.FlightDate).ToList();
        }

        public IList<Passenger> GetPassenger(Plane plane)
        {
            //liste besh naaml select l liste okhra naaml SelectMany (khater andi liste mtaa tickets f flight ), ki tabda aandi wehed khaw moush liste naaml juste Select (ticket aandha passenger wehed khaw) 
            return plane.Flights.SelectMany(p => p.Tickets).Select(t => t.Passenger).Distinct().ToList(); // distinct besh nekhou awel passenger
        }

        public bool IsAvailablePlane(Flight f, int n)
        {
            // var plane = GetAll().Where(p => p.Flights.Contains(f) == true).First(); 
             var plane = Get (p => p.Flights.Contains(f) == true); // toul nekhdem b Get taatini loula maghir .First ()
            var capacity = plane.Capacity;
            //hashti ken bel vol atheka donc nlawej aalih (flight eli metaadya entre ()
            var flight = plane.Flights.Single(j => j.FlightId == f.FlightId); // single khater metaakda besh trajaali element wahda 
            var ticket = flight.Tickets.Count();
            //condition capacite - ticket > n 
            return capacity - ticket > n;
        }
    }
}
