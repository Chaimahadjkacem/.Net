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
        public int PassengerId { get; set; }

        [Display(Name = "Date of Birth")] // ou bien DislayName  besh nbadel eli mawjoud f label
        [DataType(DataType.Date)] // nhotha date khater ma9alish nheb hata lwa9et valide 9ali juste date valide si nn ken 9ali hata mel heure valide nhot dateTime
        public DateTime BirthDate { get; set; }


        [Key]
        [MaxLength(7)]  // ou bien [Key,MaxLength(7)] hata haka shiha 
        public int PassportNumber { get; set; }

        [DataType(DataType.EmailAddress)] // ou bien [EmailAddress]
        public string EmailAddress { get; set; }


        [MinLength(3,ErrorMessage ="FirstName doit contenir au minimum 3 caractères")]
        [MaxLength(25, ErrorMessage = "FirstName doit contenir au maximum 25 caractères")]

        //public string FirstName { get; set; }
        // public string LastName { get; set; } twalii ->
        public FullName FullName{ get; set; }

    

        [MinLength(8)]
        [MaxLength(8)] // ou bien ken jet heya string moush int : [RegularExpression("[0-9]{8}")] yaani 9otlou dakhali ken les chiffres 8 marat 
        public int TelNumber { get; set; }

        //public IList<Flight> Flights { get; set; }

        //khater aamlna beha l relation
        public virtual IList<Ticket> TicketList { get; set; }


        public virtual List<Reservation> Reservations { get; set; }

        //public override string ToString()
        //{
        //  return FirstName + " " + LastName + " " + TelNumber + " " + BirthDate + " " + EmailAddress + " " + PassportNumber;
        //}

        //public bool CheckProfile( string prenom , string nom)
        //{

        //    return nom == LastName && prenom == FirstName;
        //}
        //public bool CheckProfile(string prenom, string nom , string email)
        //{

        //    return nom == LastName && prenom == FirstName && email == EmailAddress;
        //}
        //public bool CheckProfile(string prenom, string nom, string email = null)
        //{
        //    if (email == null)
        //    {
        //        return nom == LastName && prenom == FirstName;
        //    }
        //    return nom == LastName && prenom == FirstName && email == EmailAddress;

        //}

        public virtual void PassengerType()
        {
            Console.WriteLine("I am a passenger");
        }


    }
}
