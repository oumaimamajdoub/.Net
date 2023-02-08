// See https://aka.ms/new-console-template for more information
using AM.ApplicationCore.Domain;

Console.WriteLine("Hello, World!");

//constructeur par défaut
Plane plane = new Plane();
plane.Capacity = 300;
plane.ManufactureDate = DateTime.Now;
plane.PlaneType = PlaneType.Boing;
//Constructeur paramétré
Plane plane2 = new Plane(PlaneType.Boing,new DateTime(2018,2,12),200);

//initialiseur d'objet 
Plane plane3 = new Plane
{
    Capacity = 100,
    ManufactureDate = DateTime.Now,
    PlaneType = PlaneType.Boing,
    PlaneId = 2
};
Passenger passenger1 = new Passenger
{
    FirstName = "mimi",
    LastName = "majdoub",
    EmailAddress = "oumaima.majdoub@esprit.tn"

};
Staff staff1=new staff();
Console.WriteLine(passenger1.login("mimi", "majdoub"));
Console.WriteLine(passenger1.login("mimi", "majdoub", "oumaima.majdoub@esprit.tn"));
passenger1.PassengerType(); //cette methode va printer "Iam passenger"



