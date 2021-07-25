using System;
using System.Collections.Generic;
using System.Text;

namespace Epam_Task_2.Interfaces
{
    internal interface ITractor
    {
        ISemitrailer Semitrailer { get; set; }
        double Weight { get; }
        string WheelFormule { get; }
        int FuelCapacity { get; }
        double EngineVolume { get; }
        string Cabin { get; }
        double FifthWheelHeight { get; }
        double FifthWheelLoad { get; }
        double FullWeight { get; }
    }
}
