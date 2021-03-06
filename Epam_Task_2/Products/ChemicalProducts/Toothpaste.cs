using Epam_Task_2.Interfaces;
using System;

namespace Epam_Task_2.Products.ChemicalProducts
{
    /// <summary>
    /// This class describing toothpaste product
    /// </summary>
    internal class Toothpaste : IProduct
    {
        public string Type => "Chemical";
        public string Name => "Toothpaste";
        public int Quantity => 312;
        public double WeightPerUnit => 1.58;

        public override bool Equals(object obj)
        {
            return obj is Toothpaste toothpaste &&
                   Type == toothpaste.Type &&
                   Name == toothpaste.Name &&
                   Quantity == toothpaste.Quantity &&
                   WeightPerUnit == toothpaste.WeightPerUnit;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Type, Name, Quantity, WeightPerUnit);
        }

        public override string ToString()
        {
            return string.Format($@"Type: {Type} 
                                    Name: {Name} 
                                    Quantity: {Quantity}
                                    WeightPerUnit: {WeightPerUnit}");
        }
    }
}
