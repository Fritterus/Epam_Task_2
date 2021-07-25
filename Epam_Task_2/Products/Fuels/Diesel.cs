using Epam_Task_2.Interfaces;
using System;

namespace Epam_Task_2.Products.Fuels
{
    /// <summary>
    /// This class describing diesel product
    /// </summary>
    internal class Diesel : IProduct
    {
        public string Type => "Fuel";
        public string Name => "Diesel";
        public int Quantity => throw new NotImplementedException();
        public double WeightPerUnit => throw new NotImplementedException();

        public override bool Equals(object obj)
        {
            return obj is Diesel diesel &&
                   Type == diesel.Type &&
                   Name == diesel.Name &&
                   Quantity == diesel.Quantity &&
                   WeightPerUnit == diesel.WeightPerUnit;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Type, Name, Quantity, WeightPerUnit);
        }
    }
}
