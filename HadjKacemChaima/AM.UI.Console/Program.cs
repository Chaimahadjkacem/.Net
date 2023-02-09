//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System.Collections;
using System.Collections.Generic;
using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using AM.ApplicationCore.Service;

Plane p = new Plane();

p.PlaneId = 1;
p.Capacity = 100;
p.ManufactureDate = DateTime.Now;
p.PlaneType = PlaneType.Boing;

Console.WriteLine(p);

//Plane p2 = new Plane(200 , new DateTime (2023,01,03) , PlaneType.Airbus);
//Console.WriteLine(p2);

Plane p3 = new Plane()
{

    Capacity = 100,
    ManufactureDate = DateTime.Now,
    PlaneType = PlaneType.Boing

};
Console.WriteLine(p3); // Rq : L'ordre dans le constructeur n'est pas important ! 

Passenger pas = new Passenger();
pas.PassengerType();

Passenger pas1 = new Staff();
pas1.PassengerType();

Passenger pas2 = new Traveller();
pas2.PassengerType();


//TP2
// 5  Lezem f declaration nhotou Classe moush interface
ServiceFlight serviceFlight = new ServiceFlight();
serviceFlight.Flights = TestData.Flights;










