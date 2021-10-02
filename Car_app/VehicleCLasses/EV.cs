using Car_app.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Car_app.VehicleCLasses
{
    class EV : IEV
    {
        public string BodyType { get; set; }
        public int MilesPerCharge { get; set; }
        public int MinutesToCharge { get; set; }
        public string HeadlightType { get; set; }
        public int Mileage { get; set; }
        public string Drivetrain { get; set; }
        public string Engine { get; set; }
        public string Color { get; set; }
        public string Manufacturer { get; set; }

        public void printProperties()
        {
            Console.WriteLine($"Body Type: {BodyType}");
            Console.WriteLine($"Miles per charge: {MilesPerCharge}");
            Console.WriteLine($"Minutes to charge: {MinutesToCharge}");
            Console.WriteLine($"Headlight type: {HeadlightType}");
            Console.WriteLine($"Mileage: {Mileage}");
            Console.WriteLine($"Drivetrain: {Drivetrain}");
            Console.WriteLine($"Engine: {Engine}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Manufacturer: {Manufacturer}");
        }
    }
}
