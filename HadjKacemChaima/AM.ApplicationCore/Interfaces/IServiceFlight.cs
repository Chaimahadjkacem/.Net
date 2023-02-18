using AM.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Interfaces
{
    public interface IServiceFlight
    {
        public List<DateTime> GetFlightDates(string destination);
        //   public List<Flight> GetFlights(string filterType, string filterValue);
        public List<Flight> GetFlights(string filterValue, Func<Flight, string, Boolean> condition);

         public void ShowFlightDetails(Plane plane);

        public int ProgrammedFlightNumber(DateTime startDate);

        public double DurationAverage(string destination);

        public List<Flight> OrderedDurationFlights();

        public List<Traveller> SeniorTravellers(Flight flight);

        public void DestinationGroupedFlights();

        // public void ShowFlightDetails(Action<Plane> FlightDetailsDel);

        // public double DurationAverage(Func<string, float> DurationAverageDel);

    }
}
