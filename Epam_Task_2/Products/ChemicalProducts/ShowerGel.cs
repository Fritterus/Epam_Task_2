using Epam_Task_2.Interfaces;

namespace Epam_Task_2.Products.ChemicalProducts
{
    internal class ShowerGel : IProduct
    {
        public string Type => "Chemical";
        public string Name => "ShowerGel";
        public int Quantity => 320;

        public double WeightPerUnit => 1.72;
    }
}
