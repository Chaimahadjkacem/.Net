using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure.Configuration
{
    public class ReservationConfiguration : IEntityTypeConfiguration<Reservation>
    {
        public void Configure(EntityTypeBuilder<Reservation> builder)
        {
            // 3 b)
            builder.HasKey(x => new { x.SeatFk, x.PassengerFk, x.DateReservation }); // clé primaire composé (SeatFk et PassengerFk et DateReservation )
            builder.HasOne(p=> p.Passenger).WithMany(r=> r.Reservations).HasForeignKey(r=>r.PassengerFk);
            builder.HasOne(p=> p.Seat).WithMany(r=> r.Reservations).HasForeignKey(r=>r.SeatFk);
        }
    }
}
