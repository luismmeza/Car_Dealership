using System;
using System.Collections.Generic;
using System.Text;

namespace Car_app.Interfaces
{
    public interface IEV
    {
        public int MilesPerCharge { get; set; }
        public int MinutesToCharge { get; set; }
    }
}
