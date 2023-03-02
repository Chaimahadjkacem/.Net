using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Flight
    {
        public string Destination { get; set; }
        public string Departure { get; set; }
        public DateTime FlightDate { get; set; }

        
        public int FlightId { get; set; }
        public DateTime EffectiveArrival { get; set; }
        public int EstimatedDuration { get; set; }

        [ForeignKey("plane")] // foreignKey ou bien [ForeignKey(nameOf(plane))] besh nbadel esm clé etranger 
        public int ? PlaneFK { get; set; } // nzidha enaa besh najem naaml ForeignKey

        //Ou bien nhot ForeignKey hnee ama t9al9 baad f interface fel recuperation mtaa id taaml moshkla [ForeignKey(nameOf(planeFK))]
        public Plane? Plane { get; set; } // ? besh nhotou nullable

        public IList<Passenger> Passengers { get; set;}


        public override string ToString()
        {
            return FlightId + " " + Destination + " " + Departure + " " + FlightDate + " " + EffectiveArrival;
        }

    }
}
