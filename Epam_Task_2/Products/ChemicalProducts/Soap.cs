using Epam_Task_2.Interfaces;
using System;

namespace Epam_Task_2.Products.ChemicalProducts
{
    /// <summary>
    /// This class describing soap product
    /// </summary>
    internal class Soap : IProduct
    {
        public string Type => "Chemical";
        public string Name => "Soap";
        public int Quantity => 80;
        public double WeightPerUnit => 0.44;

        public override bool Equals(object obj)
        {
            return obj is Soap soap &&
                   Type == soap.Type &&
                   Name == soap.Name &&
                   Quantity == soap.Quantity &&
                   WeightPerUnit == soap.WeightPerUnit;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Type, Name, Quantity, WeightPerUnit);
        }
    }
}
