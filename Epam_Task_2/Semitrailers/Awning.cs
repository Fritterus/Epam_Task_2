using Epam_Task_2.Interfaces;
using System;

namespace Epam_Task_2.Semitrailers
{
    /// <summary>
    /// This class describing awning semitrailer
    /// </summary>
    internal class Awning : ISemitrailer
    {
        private double _currentCapacity = 0;
        public string Type => "Awning";

        public string WheelFormula => "6x2-2";

        /// <summary>
        /// Method for getting current capacity of awning semitrailer
        /// </summary>
        /// <returns>current capacity</returns>
        public double GetCurrentCapacity()
        {
            return _currentCapacity;
        }

        /// <summary>
        /// Method for setting current capacity of awning semitrailer
        /// </summary>
        /// <param name="value">current capacity value</param>
        public void SetCurrentCapacity(double value)
        {
            if (value > 0)
            {
                _currentCapacity = value;
            }
        }
        public double MaxCapacity => 35.3;

        public double BodyVolume => 30;

        public string DischargeDirection => "Back";

        public double FifthWheelHeight => 1.52;

        public double BodyLength => 8.4;

        /// <summary>
        /// Method for adding product in awning semitrailer
        /// </summary>
        /// <param name="product">product</param>
        public void AddProduct(IProduct product)
        {
            if (product.Type == "Chemical")
            {
                if ((GetCurrentCapacity() + product.Quantity * product.WeightPerUnit) < MaxCapacity)
                {
                    SetCurrentCapacity(GetCurrentCapacity() + product.Quantity * product.WeightPerUnit);
                }
                else throw new Exception("Impossible to add product");
            }
            else throw new Exception("This product is not suitable");
        }

        public override bool Equals(object obj)
        {
            return obj is Awning awning &&
                   Type == awning.Type &&
                   WheelFormula == awning.WheelFormula &&
                   MaxCapacity == awning.MaxCapacity &&
                   BodyVolume == awning.BodyVolume &&
                   DischargeDirection == awning.DischargeDirection &&
                   FifthWheelHeight == awning.FifthWheelHeight &&
                   BodyLength == awning.BodyLength;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Type, WheelFormula, MaxCapacity, BodyVolume, DischargeDirection, FifthWheelHeight, BodyLength);
        }
    }
}
