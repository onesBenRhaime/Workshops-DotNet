using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.applicationCore.domaine
{

    // 2eme methode 

    /* public enum Plantype
     {
         Boing,
         Airbus,
     } */




    public class Plane
    {
        public int PlaneId { get; set; }

        [DataType(DataType.Date)]
        public DateTime ManufactureDate { get; set; }
        public int Capacity { get; set; }

        public Plantype Plantype { get; set; }


        public IList <Flight> Flights { get; set; }

    }
}
