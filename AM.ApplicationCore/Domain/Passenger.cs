using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {


        public string PassportNumber { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }
        public int? TelNumber { get; set; }
        public string? EmailAddress { get; set; }

        public IList<Flight> Flights { get; set; }

        public override string ToString()
        {
            return "FirstName: " + FirstName + " LastName: " + LastName + " date of Birth: " + BirthDate;
        }




        //1ere methode
        public bool CheckProfile(string nom, string prenom)
        {
            return (FirstName.Equals(prenom) && LastName.Equals(nom));

        }
        //2eme methode
        public bool CheckProfile(string nom, string prenom, string email)
        {
            return (FirstName.Equals(prenom) && LastName.Equals(nom) && EmailAddress.Equals(email));

        }
        //3eme methode
        public bool login(string nom, string prenom, string email = null)
        {
            if (email != null)
                return CheckProfile(nom, prenom, email);
            return CheckProfile(nom, prenom);
            //return email!=null ? checkProfile(prenom,nom,email):checkProfile(prenom,nom);
            //?->if
            //:->else

        }
        

        public virtual void PassengerType()
        {
            //cwl( shortcut to write "console.writeln")+2 tab
            Console.WriteLine("I am passenger");

        }
       

    }
}