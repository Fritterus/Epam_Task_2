using Epam_Task2.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Epam_Task2.Products.ChemicalProducts
{
    internal class Soap : IProduct
    {
        public string Type => "Chemical";
        public string Name => "Soap";
        public int Quantity => 340;
        public double WeightPerUnit => 1.44;
    }
}
