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
                        //do something
                        isValidChoice = true;
                        break;
                    case "2":
                        isValidChoice = true;
                        //do something else
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
    }
}
