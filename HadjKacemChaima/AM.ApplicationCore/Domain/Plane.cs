using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public enum PlaneType
    {
        Boing, 
        Airbus 
    }
    public class Plane
    {
        public Plane()
        {

        }
        public Plane(int capacity, DateTime manufactureDate ,  PlaneType planeType)
        {
            Capacity = capacity;
            ManufactureDate = manufactureDate;
            PlaneType = planeType;
           
        }

        [Range(0,int.MaxValue)] // pour qu'il soit un entier positif yaani mel 0 lel +l'infini = int.MaxValue si double nhotha double.MaxValue
        public int Capacity { get; set; }
        public DateTime ManufactureDate { get; set; }


        public int PlaneId { get; set; }

        public PlaneType PlaneType { get; set; }

        //virtual khater aamlna beha relation mabin deux entités 
        public virtual IList<Flight> Flights { get; set;}

        //besh ma tetmapeech fel BD
        [NotMapped]
        public string Information { get { return Capacity + " " + PlaneId + " " + ManufactureDate + " " + PlaneType; } } // get khaw juste besh na9ra menha + nhot les attributs eli nheb naamlelhom affichage !! " " khaterha string

        public virtual List<Seat> Seats { get; set; }

        public override string ToString()
        {
            return PlaneId + " " + Capacity + " " + ManufactureDate + " " + PlaneType; 
        }

    }
}
