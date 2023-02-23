using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public static class TestData
    {
        public static List<Plane> Planes { get; set; } = new List<Plane>()
        {
            new Plane()
            {
                PlaneId= 1,
                PlaneType=PlaneType.Boing, //indice 0
                Capacity =150,
                ManufactureDate = new DateTime(2015,02,03)
            },
             new Plane()
            {
                 PlaneId= 2,
                 PlaneType=PlaneType.Airbus, // indice 1
                Capacity =250,
                ManufactureDate = new DateTime(2020,11,11)
            }

        };
        public static List<Staff> Staffs { get; set; } = new List<Staff>()
        {
            new Staff()
            {
                FirstName = "captain",
                LastName = "captain",
                EmailAddress = "Captain.captain@gmail.com",
                BirthDate= new DateTime(1965,01,01),
                EmployementDate= new DateTime(1999,01,01),
                Salary = 99999

            },
             new Staff()
            {
                FirstName = "hostess1",
                LastName = "hostess1",
                EmailAddress = "hostess1.hostess1@gmail.com",
                BirthDate= new DateTime(1995,01,01),
                EmployementDate= new DateTime(2020,01,01),
                Salary = 999
            },  
             new Staff()
            {
               FirstName = "hostess2",
                LastName = "hostess2",
                EmailAddress = "hostess2.hostess2@gmail.com",
                BirthDate= new DateTime(1996,01,01),
                EmployementDate= new DateTime(2020,01,01),
                Salary = 999
            }

        };
        public static List<Traveller> Travellers { get; set; } = new List<Traveller>()
        {
            new Traveller()
            {
                FirstName = "Traveller1",
                LastName = "Traveller1",
                EmailAddress = "Traveller1.Traveller1@gmail.com",
                BirthDate= new DateTime(1980,01,01),
                HealthInformation = "No troubles",
                Nationality = "American"


            },
             new Traveller()
            {
                 FirstName = "Traveller2",
                LastName = "Traveller2",
                EmailAddress = "Traveller2.Traveller2@gmail.com",
                BirthDate= new DateTime(1981,01,01),
                HealthInformation = "Some troubles",
                Nationality = "French"
            },
             new Traveller()
            {
                  FirstName = "Traveller3",
                LastName = "Traveller3",
                EmailAddress = "Traveller3.Traveller3@gmail.com",
                BirthDate= new DateTime(1982,01,01),
                HealthInformation = "No troubles",
                Nationality = "Tunisian"
            },   
             new Traveller()
            {
                FirstName = "Traveller4",
                LastName = "Traveller4",
                EmailAddress = "Traveller4.Traveller4@gmail.com",
                BirthDate= new DateTime(1983,01,01),
                HealthInformation = "No troubles",
                Nationality = "American"
            }, 
            new Traveller()
            {
                FirstName = "Traveller5",
                LastName = "Traveller5",
                EmailAddress = "Traveller3.Traveller5@gmail.com",
                BirthDate= new DateTime(1984,01,01),
                HealthInformation = "No troubles",
                Nationality = "Spanish"
            },
        };
        public static List<Flight> Flights { get; set; } = new List<Flight>()
        {
            new Flight()
            {
               
              FlightDate= new DateTime(2022,01,01,15,10,10),
              Destination ="Paris",
              EffectiveArrival=new DateTime(2022,02,01,17,10,10),
              Plane = Planes[1],
              EstimatedDuration = 110,
              Passengers= new List<Passenger>(Travellers)
            },
             new Flight()
            {
                 
              FlightDate= new DateTime(2022,02,01,21,10,10),
              Destination ="Paris",
              EffectiveArrival=new DateTime(2022,02,01,23,10,10),
              Plane = Planes[0],
              EstimatedDuration = 105

            },
             new Flight()
            {
                
              FlightDate= new DateTime(2022,03,01,05,10,10),
              Destination ="Paris",
              EffectiveArrival=new DateTime(2022,03,01,06,40,10),
              Plane = Planes[0],
              EstimatedDuration = 100
            },
             new Flight()
            {
                 
              FlightDate= new DateTime(2022,04,01,06,10,10),
              Destination ="Madrid",
              EffectiveArrival=new DateTime(2022,04,01,08,10,10),
               Plane = Planes[0],
              EstimatedDuration = 130
            },
            new Flight()
            {

                
              FlightDate= new DateTime(2022,05,01,17,10,10),
              Destination ="Madrid",
              EffectiveArrival=new DateTime(2022,05,01,18,50,10),
               Plane = Planes[0],
              EstimatedDuration = 105

            },
            new Flight()
            {

                
              FlightDate= new DateTime(2022,06,01,20,10,10),
              Destination ="Lisbonne",
              EffectiveArrival=new DateTime(2022,06,01,22,30,10),
               Plane = Planes[1],
              EstimatedDuration = 200
            }
        };
    }
}
