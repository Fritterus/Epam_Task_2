using Epam_Task_2.Interfaces;
using System;

namespace Epam_Task_2.Products.SpecialThermalProducts
{
    /// <summary>
    /// This class describing milk product
    /// </summary>
    internal class Milk : IProduct, ISpecialThermal
    {
        public string Type => "Termal";
        public string Name => "Milk";
        public int Quantity => 240;
        public double WeightPerUnit => 2;
        public int MinTemperature => 3;
        public int MaxTemperature => 5;

        public override bool Equals(object obj)
        {
            return obj is Milk milk &&
                   Type == milk.Type &&
                   Name == milk.Name &&
                   Quantity == milk.Quantity &&
                   WeightPerUnit == milk.WeightPerUnit &&
                   MinTemperature == milk.MinTemperature &&
                   MaxTemperature == milk.MaxTemperature;
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
