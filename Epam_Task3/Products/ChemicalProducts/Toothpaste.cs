using Epam_Task2.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Epam_Task2.Products.ChemicalProducts
{
    internal class Toothpaste : IProduct
    {
        public string Type => "Chemical";
        public string Name => "Toothpaste";
        public int Quantity => 312;
        public double WeightPerUnit => 1.58;
    }
}
