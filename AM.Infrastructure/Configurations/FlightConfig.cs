using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure.Configurations
{
    public class FlightConfig : IEntityTypeConfiguration<Flight>
    {
     
        public void Configure(EntityTypeBuilder<Flight> builder)
        {
            // Renommé la table associative
            builder.HasMany(x => x.Passengers)
                    .WithMany(x => x.Flights)
                    .UsingEntity(x => x.ToTable("VolsPassenger"));

            // one to many 
            builder.HasOne(x => x.Plane).WithMany(x =>x.Flights).HasForeignKey(x => x.PlaneFK);
        }

       
    }
}
