using System;
using System.Collections.Generic;
using System.Text;

namespace Car_app.Interfaces
{
    public interface IMotorVehicle
    {
        public string HeadlightType { get; set; }
        public int Mileage { get; set; }
        public string Drivetrain { get; set; }
        public string Engine { get; set; }
        public string Color { get; set; }
        public string Manufacturer { get; set; }

    }
}
