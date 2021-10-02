using System;
namespace Car_app.Interfaces
{
    public interface IGasVehicle : IMotorVehicle
    {
        public string OilType { get; set; }
        public string GasType { get; set; }
        public int MPG { get; set; }
        
    }
}
