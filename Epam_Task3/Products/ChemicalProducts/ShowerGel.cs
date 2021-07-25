using Epam_Task2.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Epam_Task2.Products.ChemicalProducts
{
    internal class ShowerGel : IProduct
    {
        public string Type => "Chemical";
        public string Name => "ShowerGel";
        public int Quantity => 320;

        public double WeightPerUnit => 1.72;
    }
}
