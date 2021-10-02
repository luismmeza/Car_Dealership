using Car_app.Interfaces;
using Car_app.VehicleCLasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Car_app.Main
{
    public class Runner
    {
        string answer;
        List<IMotorVehicle> vehicleList;
        public Runner() 
        {
            vehicleList = new List<IMotorVehicle>();
        }

        private void sayHello() 
        {
            Console.WriteLine("hello");
        }

        private void run() 
        {
            Console.WriteLine("Welcome to your car dealership software! by Luis & Victor ");
            bool run = true;
            while (run) 
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. Add A Car");
                Console.WriteLine("2. See my cars!");
                string answer = Console.ReadLine();
                switch (answer) 
                {
                    case "1":
                        addCar();
                        break;
                    case "2":
                        printAllCars();
                        break;
                    default:
                        break;
                }
            }
        }

        private void printAllCars() 
        {
            foreach (var car in vehicleList) 
            {
                Console.WriteLine("===================");
                car.printProperties();
                Console.WriteLine("===================");
            }
        }
        private void addCar() 
        {
            bool isValidChoice = false;
            while (!isValidChoice) 
            {
                Console.WriteLine("what kind of car is it?");
                Console.WriteLine("1. Gas");
                Console.WriteLine("2. Electric");
                string answer = Console.ReadLine();
                switch (answer)
                {
                    case "1":
                        addGasCar();
                        isValidChoice = true;
                        break;
                    case "2":
                        addEV();
                        isValidChoice = true;
                        break;
                    default:
                        Console.WriteLine("that is not an option, please type a number");
                        break;
                }
            }
        }

        private void addGasCar() 
        {
            /*public string Body_Type { get; set; }
        public string OilType { get; set; }
        public string GasType { get; set; }
        public int MPG { get; set; }
        public string HeadlightType { get; set; }
        public int Mileage { get; set; }
        public string Drivetrain { get; set; }
        public string Engine { get; set; }
        public string Color { get; set; }
        public string Manufacturer { get; set; }*/

            GasCar car = new GasCar();

            Console.WriteLine("What Body Type does it have?");
            car.Body_Type = Console.ReadLine();

        }

        private void addEV() 
        {
            /*public string BodyType { get; set; }
        public int MilesPerCharge { get; set; }
        public int MinutesToCharge { get; set; }
        public string HeadlightType { get; set; }
        public int Mileage { get; set; }
        public string Drivetrain { get; set; }
        public string Engine { get; set; }
        public string Color { get; set; }
        public string Manufacturer { get; set; }*/
            EV ev = new EV();
            Console.WriteLine("What Body type does it have?");
            ev.BodyType = Console.ReadLine();
            Console.WriteLine("What Miles per charge can it do?");
            ev.MilesPerCharge = Int32.Parse(Console.ReadLine());
            Console.WriteLine("What minutes does it take to charge?");
            ev.MinutesToCharge = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Headlight type does it have?");
            ev.HeadlightType = Console.ReadLine();
            Console.WriteLine("what is its mileage");
            ev.Mileage = Int32.Parse(Console.ReadLine());
            Console.WriteLine("what drive train does it have?");
            ev.Drivetrain = Console.ReadLine();
            Console.WriteLine("What engine does it have?");
            ev.Engine = Console.ReadLine();
            Console.WriteLine("What color is it?");
            ev.Color = Console.ReadLine();
            Console.WriteLine("What manufacturer made it?");
            ev.Manufacturer = Console.ReadLine();

            Console.WriteLine("Added the following car: ");
            ev.printProperties();
            Console.ReadLine();
            vehicleList.Add(ev);
        }
    }
}
