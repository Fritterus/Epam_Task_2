using Epam_Task_2.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Epam_Task_2.Products.SpecialThermalProducts
{
    internal class Beef : IProduct, ISpecialThermal
    {
        public string Type => "Termal";
        public string Name => "Beef";
        public int Quantity => 400;
        public double WeightPerUnit => 1.7;
        public int MinTemperature => -5;
        public int MaxTemperature => 2;
    }
}
