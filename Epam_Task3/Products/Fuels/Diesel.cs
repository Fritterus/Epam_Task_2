using Epam_Task2.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Epam_Task2.Products.Fuels
{
    internal class Diesel : IProduct
    {
        public string Type => "Fuel";
        public string Name => "Diesel";
        public int Quantity => throw new NotImplementedException();
        public double WeightPerUnit => throw new NotImplementedException();
    }
}
