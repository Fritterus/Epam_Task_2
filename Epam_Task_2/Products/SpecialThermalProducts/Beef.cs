using Epam_Task_2.Interfaces;
using System;

namespace Epam_Task_2.Products.SpecialThermalProducts
{
    /// <summary>
    /// This class describing beef product
    /// </summary>
    internal class Beef : IProduct, ISpecialThermal
    {
        public string Type => "Termal";
        public string Name => "Beef";
        public int Quantity => 400;
        public double WeightPerUnit => 1.7;
        public int MinTemperature => -5;
        public int MaxTemperature => 2;

        public override bool Equals(object obj)
        {
            return obj is Beef beef &&
                   Type == beef.Type &&
                   Name == beef.Name &&
                   Quantity == beef.Quantity &&
                   WeightPerUnit == beef.WeightPerUnit &&
                   MinTemperature == beef.MinTemperature &&
                   MaxTemperature == beef.MaxTemperature;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Type, Name, Quantity, WeightPerUnit, MinTemperature, MaxTemperature);
        }

        public override string ToString()
        {
            return string.Format($@"Type: {Type} 
                                    Name: {Name} 
                                    Quantity: {Quantity}
                                    WeightPerUnit: {WeightPerUnit}
                                    MinTemperature: {MinTemperature}
                                    MaxTemperature: {MaxTemperature}");
        }
    }
}
