using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Reservation
    {
        public DateTime DateReservation { get; set; }

        public virtual Seat Seat { get; set; }
        public virtual Passenger Passenger { get; set; }

        //[ForeignKey(nameof(Seat))] // esm attribut eli khdemna beha relation eli lfou9 
        public int SeatFk { get; set; } // lezem nafs type clé primaire mtaa seat

       //[ForeignKey(nameof(Passenger))]
        public int PassengerFk { get; set; } // lezem nafs type clé primaire mtaa Passenger


    }
}
