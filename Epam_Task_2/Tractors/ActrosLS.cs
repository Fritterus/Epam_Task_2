using Epam_Task_2.Interfaces;
using System;
using System.Collections.Generic;

namespace Epam_Task_2.Tractors
{
    /// <summary>
    /// This class describing actrosLS tractor
    /// </summary>
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

        public override bool Equals(object obj)
        {
            return obj is ActrosLS lS &&
                   EqualityComparer<ISemitrailer>.Default.Equals(_semitrailer, lS._semitrailer) &&
                   EqualityComparer<ISemitrailer>.Default.Equals(Semitrailer, lS.Semitrailer) &&
                   Weight == lS.Weight &&
                   WheelFormule == lS.WheelFormule &&
                   FuelCapacity == lS.FuelCapacity &&
                   EngineVolume == lS.EngineVolume &&
                   Cabin == lS.Cabin &&
                   FifthWheelHeight == lS.FifthWheelHeight &&
                   FifthWheelLoad == lS.FifthWheelLoad &&
                   FullWeight == lS.FullWeight;
        }

        public override int GetHashCode()
        {
            HashCode hash = new HashCode();
            hash.Add(_semitrailer);
            hash.Add(Semitrailer);
            hash.Add(Weight);
            hash.Add(WheelFormule);
            hash.Add(FuelCapacity);
            hash.Add(EngineVolume);
            hash.Add(Cabin);
            hash.Add(FifthWheelHeight);
            hash.Add(FifthWheelLoad);
            hash.Add(FullWeight);
            return hash.ToHashCode();
        }
    }
}
