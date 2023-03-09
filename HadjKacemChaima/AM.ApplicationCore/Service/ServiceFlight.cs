using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration.Assemblies;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Service
{
    public class ServiceFlight 
    {
        //Creation des délégué (question 16)
        public Action<Plane> FlightDetailsDel { get; set; }

        public Func<string, float> DurationAverageDel { get; set; }

        //Creation de constructeur (question 17) + afectation du délégués au methodes aadeya
        //  FlightDetailsDel = ShowFlightDetails; maghiir () fel methode !!!!
        // DurationAverageDel = DurationAverage;
        // affectation methode lel délégué (question 18)
        public ServiceFlight() {
            FlightDetailsDel =(Plane plane ) =>
            {
                var query = Flights
                .Where(f => f.Plane.PlaneId == plane.PlaneId) // jamais trajaa true (si ki nzidhom .PlaneId)
                .Select(f => new { f.Destination, f.FlightDate });
                foreach (var item in query)
                {
                    Console.WriteLine(item);
                }
            }; // affectation du délégué 
            DurationAverageDel = (string destination) =>
            {
                var query = Flights
                    .Where(f => f.Destination.Equals(destination))
                    .Average(f => f.EstimatedDuration);
                return ((float)query);
            };

        }


        public List<Flight> Flights { get; set; } = new List<Flight> { };  // Creation et initialisation 

      

    

        //Avec for (Question 6)

        //public List<DateTime> GetFlightDates(string destination)
        //{
        //    List<DateTime> dates = new List<DateTime>();
        //    for ( int i=0; i< Flights.Count; i++ )
        //    {
        //        if (Flights[i].Destination == destination)
        //        {
        //            dates.Add(Flights[i].FlightDate);
        //        }
        //    }
        //    return dates;
        //}

        //Avec foreach (Question 7)
        public List<DateTime> GetFlightDates(string destination)
        {
            List<DateTime> dates = new List<DateTime>();
            foreach (var flight in Flights)
            {
                if (flight.Destination == destination)
                {
                    dates.Add(flight.FlightDate);
              
                }
            }

            //19
            //1ère mèthode
            //var query = from f in Flights where f.Destination == destination select f.FlightDate;
            //return query.ToList();

            //2ème mèthode
           var query = Flights
                .Where(f=>f.Destination == destination)
                .Select(f=>f.FlightDate).ToList(); // besh tbadel IEnumerable (sortie de query) lel liste (-> cast ) 
            return query;

        }

        //8
        public List<Flight> GetFlights(string filterValue, Func<Flight, String, Boolean> condition)
        {

            /*List<Flight> flights = new List<Flight>();
            foreach (var flight in Flights)
            {
                if (condition(flight, filterValue))
                {
                    flights.Add(flight);
                    Console.WriteLine(flight);
                }
            }

            return flights;*/


            // 19 avec query 
            var query = from flight in Flights
                        where condition(flight, filterValue)
                        select flight;
            List<Flight> f = query.ToList();
            foreach (var flight in f)
            {
                Console.WriteLine(flight);
            }
            return f;

            // avec switch 
            //switch (filterType)
            //{
            //    case "Destination":
            //        foreach (var flight in Flights)
            //        {
            //            if (flight.Destination.Equals(filterValue))
            //            {
            //                flights.Add(flight);
            //            }
            //        }
            //        break;
            //    case "FlightId":
            //        foreach (var flight in Flights)
            //        {
            //            if (flight.FlightId == int.Parse(filterValue))
            //            {
            //                flights.Add(flight);
            //            }
            //        }
            //        break;

            //}



        }
        //10
        public void ShowFlightDetails(Plane plane)
        {
            var query = Flights
                .Where(f => f.Plane.PlaneId == plane.PlaneId) // jamais trajaa true (si ki nzidhom .PlaneId)
                .Select(f => new { f.Destination, f.FlightDate });
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
        }

        //11
        public int ProgrammedFlightNumber(DateTime startDate)
        {
            var query = Flights
                .Count(f => f.FlightDate > startDate && (f.FlightDate - startDate).TotalDays < 7); // ( ou where baad count ama count tehseb khaw ) ama count hnee tehseb o taaml filtre au meme temps 
                
            return query;
        }

        //12
        public float DurationAverage(string destination)
        {
            var query = Flights
                .Where(f => f.Destination.Equals(destination))
                .Average(f => f.EstimatedDuration);
            return ((float)query);
        }

        //13
        public List<Flight> OrderedDurationFlights()
        {
            //var query = Flights
            //    .OrderByDescending(f=> f.EstimatedDuration).ToList();

            var query = from f in Flights orderby(f.EstimatedDuration) descending  select f;
            return query.ToList();
        }

        //14
        //public List<Traveller> SeniorTravellers(Flight flight)
        //{
        //    var query = flight.Passengers.OfType<Traveller>()
                  
        //        .OrderBy(p=>p.BirthDate).Take(3).ToList();
        //    // ki nheb nhot liste de retour Passenger : List <Passenger> p = new List<Passenger>(query); // yaaml cast implicite fi f liste des passenger yrajaa liste des traveller
        //    return query.ToList();

        //}

        //15
        public void DestinationGroupedFlights()
        {
            var query = Flights
                .GroupBy(f => f.Destination).ToList();
            foreach (var f in query)
            {
                Console.WriteLine(f.Key);
                foreach (var g in f)
                {
                    Console.WriteLine(g.FlightDate);
                }
            }
        }


    }
}

