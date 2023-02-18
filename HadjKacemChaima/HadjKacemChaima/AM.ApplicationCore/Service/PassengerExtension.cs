using AM.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Service
{
    //20
    public static class PassengerExtension
    {
        public static void UpperFullName(this Passenger passenger)
        {
            passenger.FirstName = passenger.FirstName.ToUpper();
            passenger.LastName = passenger.LastName.ToUpper();
        }
    }
}
