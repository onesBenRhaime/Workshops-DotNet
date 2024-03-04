using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {
        //public int Id { get; set; }
        [Key, StringLength((7))]
        public string PassportNumber { get; set; }
        [MinLength(3, ErrorMessage = "longueur minimale 3 caractères"), MaxLength(25 , ErrorMessage = "longueur maximale 25 caractères")]
        public string FirstName { get; set; }

        public string LastName { get; set; }
        //pour respecter format date+ calander 
        [DataType(DataType.Date)]
        [Display(Name ="Date of Birth")]
        public DateTime BirthDate { get; set; }
        // methode 1 : [DataType(DataType.PhoneNumber)]
        //methode 2 : [Phone]
        [RegularExpression(@"^[0-9]{8}$", ErrorMessage = "Invalid Phone Number!")]
        public int? TelNumber { get; set; }
        //[DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string? EmailAddress { get; set; }

        public  IList<Flight> Flights { get; set; }

        public override string ToString()
        {
            return "FirstName: " + FirstName + " LastName: " + LastName + " date of Birth: " + BirthDate;
        }
        //Le polymorphisme par signature

        //1-

        public bool CheckProfile(string firstName, string lastName)
        {
            return FirstName == firstName && LastName == lastName;
        }

        //2-

        public bool CheckProfile(string firstName, string lastName, string email)
        {
            return FirstName == firstName && LastName == lastName && EmailAddress == email;
        }

        // 3- 
        public bool login(string firstName, string lastName, string email = null)
        {
            if (email != null)
                return FirstName == firstName && LastName == lastName && EmailAddress == email;

                return CheckProfile(firstName, lastName);   
        }
        // Polymorphisme par héritge
        public virtual void PassengerType()
        {
            Console.WriteLine("I am a Passenger");
        }
    }
}
