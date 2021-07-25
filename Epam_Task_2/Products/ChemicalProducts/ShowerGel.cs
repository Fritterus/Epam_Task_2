using Epam_Task_2.Interfaces;
using System;

namespace Epam_Task_2.Products.ChemicalProducts
{
    /// <summary>
    /// This class describing shower gel product
    /// </summary>
    internal class ShowerGel : IProduct
    {
        public string Type => "Chemical";
        public string Name => "ShowerGel";
        public int Quantity => 320;

        public double WeightPerUnit => 1.72;

        public override bool Equals(object obj)
        {
            return obj is ShowerGel gel &&
                   Type == gel.Type &&
                   Name == gel.Name &&
                   Quantity == gel.Quantity &&
                   WeightPerUnit == gel.WeightPerUnit;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Type, Name, Quantity, WeightPerUnit);
        }
    }
}
