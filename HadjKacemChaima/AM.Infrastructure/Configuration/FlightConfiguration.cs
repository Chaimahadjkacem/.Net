using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure.Configuration
{
    public class FlightConfiguration : IEntityTypeConfiguration<Flight>
    {
        public void Configure(EntityTypeBuilder<Flight> builder)
        {

            builder.HasKey(f => f.FlightId);
            builder.ToTable("MyFlight");
            builder.Property(g => g.Departure).IsRequired().HasMaxLength(100).HasColumnName("VilleDepart").HasDefaultValue("Tunis").HasColumnType("nchar"); // maaneha n caractère heya bidha varchar wala najem hata nvarchar
            builder.HasOne(f => f.Plane).WithMany(p => p.Flights).HasForeignKey(f => f.PlaneFK).OnDelete(DeleteBehavior.SetNull);//besh nbadel esm ForeignKey
            builder.HasMany(f => f.Passengers).WithMany(f => f.Flights).UsingEntity(p => p.ToTable("MyReservation"));//nbadel esm table
        }
    }
}
