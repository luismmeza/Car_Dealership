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
        List<string> mainmenulist;
        List<string> deletemenulist;
        public Runner() 
        {
            mainmenulist = new List<string> { "What would you like to do?", "1. Add A Car" , "2. See my cars!", "3. delete a car" };
            vehicleList = new List<IMotorVehicle>();
            deletemenulist = new List<string> { "1. see all cars", "2. enter index number" };
        }

        private void sayHello() 
        {
            Console.WriteLine("hello");
        }

        public void run() 
        {
            Console.WriteLine("Welcome to your car dealership software! by Luis & Victor ");

            bool run = true;
            while (run) 
            {
                printalloptions(mainmenulist);
                string answer = Console.ReadLine();
                switch (answer) 
                {
                    case "1":
                        addCar();
                        break;
                    case "2":
                        printAllCars();
                        break;
                    case "3":
                        deletecar();
                        break;
                    default:
                        break;

                }
            }
        }

        private void printAllCars() 
        {
            for (int a = 0;a < vehicleList.Count; a++)
            {
                Console.WriteLine("===================");

                var car = vehicleList[a];
                car.printProperties();
                Console.WriteLine(a);
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

            //Int32.Parse(Console.ReadLine());

            GasCar car = new GasCar();

            Console.WriteLine("What Body Type does it have?");
            car.Body_Type = Console.ReadLine();
            Console.WriteLine("What Oil Type does it have");
                car.OilType = Console.ReadLine();
            Console.WriteLine("What Gas Type does it take");
                car.GasType = Console.ReadLine();
            Console.WriteLine("how many MPG does it get");
            car.MPG = Int32.Parse(Console.ReadLine());
            Console.WriteLine("what kind of headlights does it have");
            car.HeadlightType = Console.ReadLine();
            Console.WriteLine("how many miles does the car have");
            car.Mileage = Int32.Parse(Console.ReadLine());
            Console.WriteLine("what kind of drivetrain does it have");
                car.Drivetrain = Console.ReadLine();
            Console.WriteLine("what kind of engine does it have");
            car.Engine = Console.ReadLine();
            Console.WriteLine("what kind of color is it");
            car.Color = Console.ReadLine();
            Console.WriteLine("who is the manufacturer");
            car.Manufacturer = Console.ReadLine();

            Console.WriteLine("Added the following car: ");
            car.printProperties();
            Console.ReadLine();
            vehicleList.Add(car);
        }

        private void addEV() 
        {
            /*public string BodyType { get; set; }
        public int MilesPerCharge { get; set; }
        public int MinutesToCharge  { get; set; }
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

        private void printalloptions(List<string> options)
        {
            Console.WriteLine("??????????????????????");
            foreach(string option in options)
            {
                Console.WriteLine(option);

            }
            Console.WriteLine("??????????????????????");
        }

        private void deletecar()
        {
            Console.WriteLine("what car do you want to delete");
            printalloptions(deletemenulist);
            string response = Console.ReadLine();
            switch (response)
            {
                case "1":
                    printAllCars();
                    break;
                case "2":
                    Console.WriteLine("please type index number here");
                    string answer = Console.ReadLine();
                    vehicleList.RemoveAt(Int32.Parse(answer));
                    break;
                default:
                    Console.WriteLine("this is not an option, please pick one listed");
                    break;


            }
            
        }
    }
}




/*
 
 string[] a = new string[3]
 
 a[0] = "sample1"
 a[1] = "sample2"
 a[2] = "sample3"
 
 
 
 
 
 */