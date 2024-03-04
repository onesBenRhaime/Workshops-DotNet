using AM.ApplicationCore.Domain;
using AM.Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure
{
    public class AMContext : DbContext
    {

     public DbSet<Flight> Flights { get; set; }
     public DbSet<Plane> Planes { get; set; }
     public DbSet<Passenger> Passengers { get; set; }
     public DbSet<Staff> Staffs { get; set; }
     public DbSet<Traveller> Travellers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                                        @"Data Source=(localdb)\mssqllocaldb;
                                        Initial Catalog=AirportManagementDB;
                                        Integrated Security=true"
                                    );        
            base.OnConfiguring(optionsBuilder);

        }
        //Fluent API
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PlaneConfig());
            modelBuilder.ApplyConfiguration(new FlightConfig());
            base.OnModelCreating(modelBuilder);
        }
    }
}
