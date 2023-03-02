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
            passenger.FirstName = passenger.FirstName[0].ToString().ToUpper() + passenger.FirstName.Substring(1);// khater aandi juste caractère kahw lowel howa majuscule + nzid b9eyet e chaine b substring eli temshi men indice 1 l ekher chaine mtaa firstname 
            passenger.LastName = passenger.LastName[0].ToString().ToUpper() + passenger.LastName.Substring(1);
        }
    }
}
