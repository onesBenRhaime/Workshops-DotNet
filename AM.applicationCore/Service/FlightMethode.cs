using AM.applicationCore.domaine;
using AM.applicationCore.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AM.applicationCore.Service
{
    internal class FlightMethode : IFlightMethode

    {
      public IList<Flight> flights = new List<Flight>();
      public  IList<DateTime> GetFlightDates(string destination)
        {
            /*  IList<DateTime> result = new List<DateTime>();
              foreach (var item in flights)
              {
                  if (item.Destination.Equals(destination))
                  {
                      result.Add(item.FlightDate); 
                  }
              }
              return result;
            */
            //Link
            var query = from flight in flights where flight.Destination == destination select flight.FlightDate;
            return query.ToList();
        }

    

        public void ShowFlightDetails(Plane plane)
        {
            var query = from  p in plane.Flights select  new {p.Destination , p.FlightDate};

            foreach (var item in query)
            {
                    Console.WriteLine(item.Destination + item.FlightDate);

            }
        }
        public int ProgrammedFlightNumber(DateTime startDate)
        {
            /* Linq 
                        DateTime endDate = startDate.AddDays(7);

                        int numberOfFlights = (from flight in flights
                                               where flight.FlightDate >= startDate && flight.FlightDate < endDate
                                               select flight).Count();

                        return numberOfFlights;*/

            //Lambda

            return flights.Count(f => f.FlightDate > startDate.AddDays(7));
          

        }

        public double DurationAverage(string destination)
        {
            /*  var averageDuration = (from flight in flights
                                     where flight.Destination == destination
                                     select flight.EstimateDuration).Average();

              return averageDuration;*/
            return flights.Where(f => f.Destination == destination).Average(f=>f.EstimateDuration);
        }
        ///13. Retourner les Vols ordonnés par EstimatedDuration du plus long au plus court
        public IEnumerable<Flight> OrderedDurationFlights()
        {

            /****linq 
            var query = from f  in flights
                        orderby f.EstimateDuration descending
                        select f;
            ///select oblegatoire fil linq

            return query.ToList();
            *****/
            /**Lambda 
                   var Lambda = Collections.Where(instance x =>condition)
                        .Select(X=>x)
            ****/
            var Lambda = flights.OrderByDescending(f => f.EstimateDuration)
                          .Select(f => f);
            return Lambda;
        }

        public void ShowFlightDetails(domaine.Plane plane)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Flight> SeniorTravellers(Flight flight)
        {

           /* //linq */
            var query = from a in flight.Passengers.OfType<Traveller>().ToList()
                        orderby a.BirthDate
                        select a;

            return (IEnumerable<Flight>)query.Take(3);
            //lambda 

          //return flight.Passengers.OfType<Traveller>().OrderBy(a => a.BirthDate).Take(3);


        }
    }
}
