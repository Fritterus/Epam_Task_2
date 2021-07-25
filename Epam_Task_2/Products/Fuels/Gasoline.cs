using Epam_Task_2.Interfaces;
using System;

namespace Epam_Task_2.Products.Fuels
{
    /// <summary>
    /// This class describing gasoline product
    /// </summary>
    internal class Gasoline : IProduct
    {
        public string Type => "Fuel";
        public string Name => "Gasoline";

        public int Quantity => throw new NotImplementedException();

        public double WeightPerUnit => throw new NotImplementedException();

        public override bool Equals(object obj)
        {
            return obj is Gasoline gasoline &&
                   Type == gasoline.Type &&
                   Name == gasoline.Name &&
                   Quantity == gasoline.Quantity &&
                   WeightPerUnit == gasoline.WeightPerUnit;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Type, Name, Quantity, WeightPerUnit);
        }
    }
}
