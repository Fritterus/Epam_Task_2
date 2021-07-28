using Epam_Task_2.Interfaces;
using System;
using System.Collections.Generic;

namespace Epam_Task_2.Tractors
{
    /// <summary>
    /// This class describing DAF tractor
    /// </summary>
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
                else
                {
                    throw new Exception("This semitrailer cant be attached to this tractor");
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

        public override bool Equals(object obj)
        {
            return obj is DAF dAF &&
                   EqualityComparer<ISemitrailer>.Default.Equals(_semitrailer, dAF._semitrailer) &&
                   EqualityComparer<ISemitrailer>.Default.Equals(Semitrailer, dAF.Semitrailer) &&
                   Weight == dAF.Weight &&
                   WheelFormule == dAF.WheelFormule &&
                   FuelCapacity == dAF.FuelCapacity &&
                   EngineVolume == dAF.EngineVolume &&
                   Cabin == dAF.Cabin &&
                   FifthWheelHeight == dAF.FifthWheelHeight &&
                   FifthWheelLoad == dAF.FifthWheelLoad &&
                   FullWeight == dAF.FullWeight;
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
