using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.applicationCore.domaine
{
    public  class Flight
    {
       // public Flight() { }
       /* public Flight(int flightId, DateTime flightDate)
        {
            FlightId = flightId;
            FlightDate = flightDate;
        } */ 

        public int FlightId { get; set; }

        public DateTime FlightDate { get; set; }
        public int EstimateDuration { get; set; }

        public DateTime EffectiveArrival { get; set; }
        public string Departure { get; set; }
        public string Destination { get; set; }

        public Plane Plane { get; set; }


        public IList<Passenger> Passengers { get; set; }

        public override string? ToString()
        {
            return " FlightId " + FlightId ;
        }
    }
}
