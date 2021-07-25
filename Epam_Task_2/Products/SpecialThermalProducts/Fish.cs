using Epam_Task_2.Interfaces;
using System;

namespace Epam_Task_2.Products.SpecialThermalProducts
{
    internal class Fish : IProduct, ISpecialThermal
    {
        public string Type => "Termal";
        public string Name => "Fish";
        public int Quantity => 300;
        public double WeightPerUnit => 1.4;
        public int MinTemperature => -25;
        public int MaxTemperature => -15;

        public override bool Equals(object obj)
        {
            return obj is Fish fish &&
                   Type == fish.Type &&
                   Name == fish.Name &&
                   Quantity == fish.Quantity &&
                   WeightPerUnit == fish.WeightPerUnit &&
                   MinTemperature == fish.MinTemperature &&
                   MaxTemperature == fish.MaxTemperature;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Type, Name, Quantity, WeightPerUnit, MinTemperature, MaxTemperature);
        }
    }
}
