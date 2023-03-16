using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure.Configuration
{
    public class TicketConfiguration : IEntityTypeConfiguration<Ticket>
    {
        public void Configure(EntityTypeBuilder<Ticket> builder)
        {
            builder.HasKey(x => new { x.PassengerFk, x.FlightFk }); // clé primaire composé (passengerfk et flight fk )
            //pour configurer les cles etrangères 
            builder.HasOne(p => p.Passenger).WithMany(x => x.TicketList).HasForeignKey(t=>t.PassengerFk); // ticketList esm propriete eli f passenger 
            builder.HasOne(p => p.Flight).WithMany(x => x.Tickets).HasForeignKey(t => t.FlightFk); 
        }
    }
}
