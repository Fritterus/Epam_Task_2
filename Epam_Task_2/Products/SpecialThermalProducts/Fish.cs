using Epam_Task_2.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Epam_Task_2.Products.SpecialThermalProducts
{
    internal class Fish : IProduct, ISpecialThermal
    {
        public string Type => "Termal";
        public string Name => "Fish";
        public int Quantity => 300;
        public double WeightPerUnit => 1.4;
        public int MinTemperature => -25;
        public int MaxTemperature => -15;
    }
}
