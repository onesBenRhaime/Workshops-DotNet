using AM.applicationCore.domaine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.applicationCore.Interface
{
    internal interface IFlightMethode
    {
        IList<DateTime> GetFlightDates(string destination);
        void ShowFlightDetails(Plane plane);
        IEnumerable<Flight> OrderedDurationFlights();
        IEnumerable<Flight> SeniorTravellers(Flight flight);
    }
}
