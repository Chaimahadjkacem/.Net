//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System.Collections;
using System.Collections.Generic;
using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using AM.ApplicationCore.Service;
using AM.Infrastructure;

//Plane p = new Plane();

//p.PlaneId = 1;
//p.Capacity = 100;
//p.ManufactureDate = DateTime.Now;
//p.PlaneType = PlaneType.Boing;

//Console.WriteLine(p);

//Plane p2 = new Plane(200 , new DateTime (2023,01,03) , PlaneType.Airbus);
//Console.WriteLine(p2);

//Plane p3 = new Plane()
//{

//    Capacity = 100,
//    ManufactureDate = DateTime.Now,
//    PlaneType = PlaneType.Boing

//};
//Console.WriteLine(p3); // Rq : L'ordre dans le constructeur n'est pas important ! 

Passenger pas = new Passenger();
//pas.PassengerType();

//Passenger pas1 = new Staff();
//pas1.PassengerType();

//Passenger pas2 = new Traveller();
//pas2.PassengerType();


//TP2
// 5  Lezem f declaration nhotou Classe moush interface
//ServiceFlight serviceFlight = new ServiceFlight();
//serviceFlight.Flights = TestData.Flights;

////Methodes anonymes
//ServiceFlight ServiceFlight = new ServiceFlight();
//serviceFlight.Flights = TestData.Flights;

//serviceFlight.GetFlights("Paris", delegate (Flight f, string c)
//{
//    return f.Destination == c;
//});

////expression lampda (fi outh delegate twali " => " )
//serviceFlight.GetFlights("2023/01/01", (Flight f, string c) =>
//{
//    return f.FlightDate.Equals(c);
//});

//float l=serviceFlight.DurationAverageDel("Paris");
//Console.WriteLine(l);

//test pour IntExtension 

int a = 11;
a.add(20);


// Pour tester PassengerExtension
//Passenger pas2 = new Staff();
//pas2 = TestData.Staffs[1];
//pas2.UpperFullName();
//Console.WriteLine(pas2.FirstName + " " + pas2.LastName);

//instruction pour communiquer avec la base de données  : instance de classe de contexte
AMContexte aMContexte = new AMContexte();
/*aMContexte.Flights.Add(new Flight() {
    Destination = "Tunis", Departure = "Sfax" ,EffectiveArrival = new DateTime(2021,02,01), EstimatedDuration = 100, FlightDate = new DateTime (2020,03,02) ,
    Plane = new Plane()
    {
        Capacity = 100,
        ManufactureDate = new DateTime(2021,03,02),
        PlaneType = PlaneType.Boing
    }
});
aMContexte.SaveChanges(); // besh nhez kol shy lel bd */

foreach (var item in aMContexte.Flights.ToList()) //kayenha select * from flights
{
    Console.WriteLine(item.FlightId+" "+item.Plane.Capacity+" "+item.Plane.ManufactureDate);
}











