using System;
using System.Collections.Generic;
using System.Text;

namespace Epam_Task2.Interfaces
{
    internal interface IProduct
    {
        public string Type { get; }
        public string Name { get; }
        public int Quantity { get; }
        public double WeightPerUnit { get; }
    }
}
