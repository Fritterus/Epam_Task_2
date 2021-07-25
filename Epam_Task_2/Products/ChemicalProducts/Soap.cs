using Epam_Task_2.Interfaces;

namespace Epam_Task_2.Products.ChemicalProducts
{
    internal class Soap : IProduct
    {
        public string Type => "Chemical";
        public string Name => "Soap";
        public int Quantity => 340;
        public double WeightPerUnit => 1.44;
    }
}
