using Epam_Task2.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Epam_Task2.Semitrailers
{
    internal class Refrigerator : ISemitrailer
    {
        public string Type => "Refrigerator";

        public string WheelFormula => "6x6";

        public double GetCurrentCapacity()
        {
            return 0;
        }
        public void SetCurrentCapacity(double value)
        {
            if (value > 0)
            {
                SetCurrentCapacity(value);
            }
        }
        public double MaxCapacity => 36.2;

        public double BodyVolume => 32;

        public string DischargeDirection => "Back";

        public double FifthWheelHeight => 1.42;

        public double BodyLength => 8.65;

        public void AddProduct(IProduct product)
        {
            if (product.Type == "Thermal")
            {
                if ((GetCurrentCapacity() + product.Quantity * product.WeightPerUnit) < MaxCapacity)
                {
                    SetCurrentCapacity(GetCurrentCapacity() + product.Quantity * product.WeightPerUnit);
                }
                else throw new Exception("Impossible to add product");
            }
            else throw new Exception("This product is not suitable");
        }
    }
}
