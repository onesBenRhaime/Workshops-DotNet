using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.applicationCore.domaine
{
    public class Passenger
    {
        public int Id { get; set; }
        public string PassportNumber { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        public int TelNumber { get; set; }

        public string EmailAdress { get; set; }


        public IList<Flight> Flights { get; set; }














    }
}
