﻿using Epam_Task_2.Interfaces;
using System;

namespace Epam_Task_2.Products.Fuels
{
    internal class Diesel : IProduct
    {
        public string Type => "Fuel";
        public string Name => "Diesel";
        public int Quantity => throw new NotImplementedException();
        public double WeightPerUnit => throw new NotImplementedException();
    }
}
