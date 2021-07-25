using Epam_Task_2.Interfaces;

namespace Epam_Task_2.Products.SpecialThermalProducts
{
    internal class Milk : IProduct, ISpecialThermal
    {
        public string Type => "Termal";
        public string Name => "Milk";
        public int Quantity => 240;
        public double WeightPerUnit => 2;
        public int MinTemperature => 3;
        public int MaxTemperature => 5;
    }
}
