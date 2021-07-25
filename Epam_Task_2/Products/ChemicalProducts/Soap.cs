using Epam_Task_2.Interfaces;
using System;

namespace Epam_Task_2.Products.ChemicalProducts
{
    internal class Soap : IProduct
    {
        public string Type => "Chemical";
        public string Name => "Soap";
        public int Quantity => 340;
        public double WeightPerUnit => 1.44;

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
