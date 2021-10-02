using System;
using Car_app.Interfaces;

namespace Car_app.VehicleCLasses
{
    public class GasCar : IGasVehicle
    {
        public string Body_Type { get; set; }
        public string OilType { get; set; }
        public string GasType { get ; set ; }
        public int MPG { get ; set ; }
        public string HeadlightType { get ; set ; }
        public int Mileage { get ; set; }
        public string Drivetrain { get ; set ; }
        public string Engine { get ; set; }
        public string Color { get ; set ; }
        public string Manufacturer { get ; set ; }

        public GasCar()
        { }

        public void printProperties()
        {
            Console.WriteLine($"Body Type: {Body_Type}");
            Console.WriteLine($"Oil Type: {OilType}");
            Console.WriteLine($"Gas Type: {GasType}");
            Console.WriteLine($"MPG: {MPG}");
            Console.WriteLine($"Headlight Type: {HeadlightType}");
            Console.WriteLine($"Mileage: {Mileage}");
            Console.WriteLine($"Drivetrain: {Drivetrain}");
            Console.WriteLine($"Engine: {Engine}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Manufacturer: {Manufacturer}");
        }
    }
}
