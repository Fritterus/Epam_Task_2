using Epam_Task2.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Epam_Task2.Products.SpecialThermalProducts
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
