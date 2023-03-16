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
    public class SeatConfiguration : IEntityTypeConfiguration<Seat>
    {
        public void Configure(EntityTypeBuilder<Seat> builder)
        {
            //3 a)
            builder.HasOne(x => x.Section).WithMany(s => s.Seats).HasForeignKey(p => p.SectionFk).OnDelete(DeleteBehavior.SetNull); // desactiver cascade on delete bel deletebehavior
        }
    }
}
