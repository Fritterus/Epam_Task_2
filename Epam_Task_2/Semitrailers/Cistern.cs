using Epam_Task_2.Interfaces;
using System;

namespace Epam_Task_2.Semitrailers
{
    /// <summary>
    /// This class describing cistern semitrailer
    /// </summary>
    internal class Cistern : ISemitrailer
    {
        private double _currentCapacity = 0;
        public string Type => "Cistern";
        public string WheelFormula => "6x6";
        public double MaxCapacity => 33.65;

        /// <summary>
        /// Method for getting current capacity of cistern semitrailer
        /// </summary>
        /// <returns>current capacity</returns>
        public double GetCurrentCapacity()
        {
            return _currentCapacity;
        }

        public void SetCurrentCapacity(double value)
        {
            if (value > 0)
            {
                _currentCapacity = value;
            }
        }
        public double BodyVolume => 30;
        public string DischargeDirection => "Back";
        public double FifthWheelHeight => 1.35;
        public double BodyLength => 8.44;

        /// <summary>
        /// Method for adding product in cistern semitrailer
        /// </summary>
        /// <param name="product">product</param>
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

        public override bool Equals(object obj)
        {
            return obj is Cistern cistern &&
                   Type == cistern.Type &&
                   WheelFormula == cistern.WheelFormula &&
                   MaxCapacity == cistern.MaxCapacity &&
                   BodyVolume == cistern.BodyVolume &&
                   DischargeDirection == cistern.DischargeDirection &&
                   FifthWheelHeight == cistern.FifthWheelHeight &&
                   BodyLength == cistern.BodyLength;
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
