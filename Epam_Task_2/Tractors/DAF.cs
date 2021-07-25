using Epam_Task_2.Interfaces;

namespace Epam_Task_2.Tractors
{
    internal class DAF : ITractor
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

        public double Weight => 7.8;

        public string WheelFormule => "6x6";

        public int FuelCapacity => 650;

        public double EngineVolume => 12;

        public string Cabin => "Low";

        public double FifthWheelHeight => 1.25;

        public double FifthWheelLoad => 16.8;

        public double FullWeight => 46;
    }
}
