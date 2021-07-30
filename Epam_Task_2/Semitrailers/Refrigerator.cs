using Epam_Task_2.Interfaces;
using System;

namespace Epam_Task_2.Semitrailers
{
    /// <summary>
    /// This class describing refrigerator semitrailer
    /// </summary>
    internal class Refrigerator : ISemitrailer
    {
        private double _currentCapacity;
        public string Type => "Refrigerator";

        public string WheelFormula => "6x6";

        /// <summary>
        /// Method for getting current capacity of refrigerator semitrailer
        /// </summary>
        /// <returns>current capacity</returns>
        public double GetCurrentCapacity()
        {
            return _currentCapacity;
        }

        /// <summary>
        /// Method for setting current capacity of regrigerator semitrailer
        /// </summary>
        /// <param name="value">current capacity value</param>
        public void SetCurrentCapacity(double value)
        {
            if (value > 0)
            {
                _currentCapacity = value;
            }
        }
        public double MaxCapacity => 36.2;

        public double BodyVolume => 32;

        public string DischargeDirection => "Back";

        public double FifthWheelHeight => 1.42;

        public double BodyLength => 8.65;

        /// <summary>
        /// Method for adding product in regrigerator semitrailer
        /// </summary>
        /// <param name="product">product</param>
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

        public override bool Equals(object obj)
        {
            return obj is Refrigerator refrigerator &&
                   Type == refrigerator.Type &&
                   WheelFormula == refrigerator.WheelFormula &&
                   MaxCapacity == refrigerator.MaxCapacity &&
                   BodyVolume == refrigerator.BodyVolume &&
                   DischargeDirection == refrigerator.DischargeDirection &&
                   FifthWheelHeight == refrigerator.FifthWheelHeight &&
                   BodyLength == refrigerator.BodyLength;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Type, WheelFormula, MaxCapacity, BodyVolume, DischargeDirection, FifthWheelHeight, BodyLength);
        }

        public override string ToString()
        {
            return string.Format($@"Type: {Type} 
                                    WheelFormula: {WheelFormula} 
                                    CurrentCapacity: {_currentCapacity}
                                    MaxCapacity: {MaxCapacity}
                                    BodyVolume: {BodyVolume}
                                    DischargeDirection: {DischargeDirection}
                                    FiftWheelHeight: {FifthWheelHeight}");
        }
    }
}
