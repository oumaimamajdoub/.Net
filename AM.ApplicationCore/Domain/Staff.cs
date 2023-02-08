using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Staff : Passenger
    {

        public string Function { get; set; }
        public DateTime EmployementDate { get; set; }
        public float Salary { get; set; }

        //ovveride indique qu'on peut réimpliquer la methode PassengerType()
       public override void PassengerType()
        {
            base.PassengerType();
            Console.WriteLine("Iam staff");
        }



    }
}
