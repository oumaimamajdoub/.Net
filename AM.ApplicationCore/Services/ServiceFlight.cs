using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public class ServiceFlight :IServiceFlight
    {
        IList<Flight> listeFlights = new List<Flight>();
        public IList<DateTime> GetFlightDates(string destination)
    {
            IList<DateTime> listeDates = new List<DateTime>();
            foreach (var  flight in listeFlights)
            {
                if (flight.Destination == destination)
                    listeDates.Add(flight.FlightDate);

            }
            return listeDates;
        }
        public void ShowFlightDetails(Plane plane)
        {
            var query = from Flight
                        in listeFlights
                                    where Flight.Plane.Equals(plane)
                   select Flight.Plane;
        }

    }
}
