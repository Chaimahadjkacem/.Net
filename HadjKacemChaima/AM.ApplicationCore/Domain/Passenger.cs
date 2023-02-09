using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {
        public DateTime BirthDate { get; set; }
        public int PassportNumber { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int TelNumber { get; set; }

        public IList<Flight> Flights { get; set; }


        public override string ToString()
        {
            return FirstName + " " + LastName + " " + TelNumber + " " + BirthDate + " " + EmailAddress + " " + PassportNumber;
        }

        //public bool CheckProfile( string prenom , string nom)
        //{
           
        //    return nom == LastName && prenom == FirstName;
        //}
        //public bool CheckProfile(string prenom, string nom , string email)
        //{

        //    return nom == LastName && prenom == FirstName && email == EmailAddress;
        //}
        public bool CheckProfile(string prenom, string nom, string email = null)
        {
            if (email == null)
            {
                return nom == LastName && prenom == FirstName
            }
            return nom == LastName && prenom == FirstName && email == EmailAddress;

        }

        public virtual void PassengerType()
        {
            Console.WriteLine("I am a passenger");
        }


    }
}
