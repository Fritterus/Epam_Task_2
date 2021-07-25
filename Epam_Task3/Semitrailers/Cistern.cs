using Epam_Task2.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Epam_Task2.Semitrailers
{
    internal class Cistern : ISemitrailer
    {
        public string Type => "Cistern";
        public string WheelFormula => "6x6";
        public double MaxCapacity => 33.65;

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
        public double BodyVolume => 30;
        public string DischargeDirection => "Back";
        public double FifthWheelHeight => 1.35;
        public double BodyLength => 8.44;

        public void AddProduct(IProduct product)
        {
            if (product.Type == "Fuel")
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
