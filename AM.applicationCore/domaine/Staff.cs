using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.applicationCore.domaine
{
    public class Staff:Passenger
    {
        public double Salaire { get; set; }
        public string Function { get; set; }

        [DataType(DataType.Date)]
        public DateTime EmployementDate { get; set; }
    }
}
