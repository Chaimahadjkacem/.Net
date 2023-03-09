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
    public class PassengerConfiguration : IEntityTypeConfiguration<Passenger>
    {
        public void Configure(EntityTypeBuilder<Passenger> builder)
        {
            builder.OwnsOne(s => s.FullName, f=>
            { 
                f.Property(k => k.FirstName).IsRequired().HasMaxLength(30).HasColumnName("FirstName");// nbadlou esm column f base khater howa yhot esm l classe eli jeb menha+ esm attribut donc nbadlu l esm kima nhebou ena 
                f.Property(k => k.LastName).IsRequired().HasMaxLength(30).HasColumnName("LastName");
               
            });
          //  builder.HasDiscriminator<int>("type").HasValue<Passenger>(0).HasValue<Staff>(2).HasValue<Traveller>(3); // lezem type de column + esm column ("type") esm descriminator howa esm classe (Passenger) -> hethi tph (lkol fard table)
        }
        
    }
}
