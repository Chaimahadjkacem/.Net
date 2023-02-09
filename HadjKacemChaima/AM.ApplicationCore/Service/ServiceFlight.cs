using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Service
{
    public class ServiceFlight : IServiceFlight
    {
        public List<Flight> Flights { get; set; } = new List<Flight> { };  // Creation et initialisation 

        //Avec for 

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

        //Avec foreach
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
            return dates;
            }

        //8
        public List<Flight> GetFlights(string filterType, string filterValue)
        {
           
                List<Flight> flights = new List<Flight>();

                if (filterType.Equals("Destination"))
                {
                    foreach (var flight in Flights)
                    {
                        if (flight.Destination.Equals(filterValue))
                        {
                        flights.Add(flight);
                        }
                    }
                }

                if (filterType.Equals("Departure"))
                {
                    foreach (var flight in Flights)
                    {
                        if (flight.Departure.Equals(filterValue))
                        {
                        flights.Add(flight);
                        }
                    }
                }

                if (filterType.Equals("EstimatedDuration"))
                {
                    foreach (var flight in Flights)
                    {
                        if (flight.EstimatedDuration.Equals(filterValue))
                        {
                        flights.Add(flight);
                        }
                    }
                }

                if (filterType.Equals("FlightDate"))
                {
                    foreach (var flight in Flights)
                    {
                        DateTime dateTime = new DateTime();
                        dateTime = DateTime.Parse(filterValue);
                        if (flight.FlightDate == dateTime)
                        {
                        flights.Add(flight);
                        }
                    }
                }

                if (filterType.Equals("EffectiveArrival"))
                {
                    foreach (var flight in Flights)
                    {
                        DateTime dateTime = new DateTime();
                        dateTime = DateTime.Parse(filterValue);
                        if (flight.EffectiveArrival == dateTime)
                        {
                        flights.Add(flight);
                        }
                    }
                }

                if (filterType.Equals("FlightId"))
                {
                    foreach (var flight in Flights)
                    {
                        int k = int.Parse(filterValue);
                        if (flight.FlightId == k)
                        {
                        flights.Add(flight);
                        }
                    }
                }

                return flights;
        }

    }
}


    }
}
