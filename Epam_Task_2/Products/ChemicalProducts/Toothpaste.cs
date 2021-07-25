using Epam_Task_2.Interfaces;

namespace Epam_Task_2.Products.ChemicalProducts
{
    internal class Toothpaste : IProduct
    {
        public string Type => "Chemical";
        public string Name => "Toothpaste";
        public int Quantity => 312;
        public double WeightPerUnit => 1.58;
    }
}
