using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Seat
    {
        public int SeatId { get; set; }
        [Required(ErrorMessage = "Name Obligatoire")]
        [MinLength(1)]
        public string Name { get; set; }
        public string SeatNumber { get; set; }

        [Range(0,20)] //nombre positif et ne depasse pas valeur 20
        public string Size { get; set; }

        public virtual Plane Plane { get; set; }

        [ForeignKey(nameof(Plane))] // e 
        public int PlaneFk { get; set; } //e 
        public virtual Section? Section { get; set; } // ? : besh nhot colone foreign key nullable

        [ForeignKey(nameof(Section))]
        public int? SectionFk { get; set; }
        public virtual List<Reservation> Reservations { get; set; }
    }
}
