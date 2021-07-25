using Epam_Task_2.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Epam_Task_2.Tractors
{
    internal class ActrosLS : ITractor
    {
        private ISemitrailer _semitrailer;
        public ISemitrailer Semitrailer
        {
            get => _semitrailer;
            set
            {
                if (value.GetCurrentCapacity() <= FullWeight)
                {
                    _semitrailer = value;
                }
            }
        }
        public double Weight => 7.6;

        public string WheelFormule => "6x2-2";

        public int FuelCapacity => 650;

        public double EngineVolume => 12;

        public string Cabin => "High";

        public double FifthWheelHeight => 1.15;

        public double FifthWheelLoad => 16.5;

        public double FullWeight => 44;
    }
}
