﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Epam_Task2.Interfaces
{
    internal interface ISemitrailer
    {
        public string Type { get; }
        public string WheelFormula { get; }
        public double GetCurrentCapacity();
        public void SetCurrentCapacity(double value);
        public double MaxCapacity { get; }
        public double BodyVolume { get; }
        public string DischargeDirection { get; }
        public double FifthWheelHeight { get; }
        public double BodyLength { get; }

        public void AddProduct(IProduct product);
    }
}