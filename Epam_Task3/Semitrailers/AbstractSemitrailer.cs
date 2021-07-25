using Epam_Task2.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Epam_Task2.Semitrailers
{
    internal class AbstractSemitrailer : ISemitrailer
    {
        private readonly string _type;
        private readonly string _wheelFormula;
        private readonly double _currentCapacity;
        private readonly double _maxCapacity;
        private readonly double _bodyVolume;
        private readonly string _dischargeDirection;
        private readonly double _fifthWheelHeight;
        private readonly double _bodyLength;

        public AbstractSemitrailer(string type,
                                   string wheelFormula,
                                   double currentCapacity,
                                   double maxCapacity,
                                   double bodyVolume,
                                   string dischargeDirection,
                                   double fifthWheelHeight,
                                   double bodyLength)
        {
            _type = type;
            _wheelFormula = wheelFormula;
            _currentCapacity = currentCapacity;
            _maxCapacity = maxCapacity;
            _bodyVolume = bodyVolume;
            _dischargeDirection = dischargeDirection;
            _fifthWheelHeight = fifthWheelHeight;
            _bodyLength = bodyLength;
        }

        public string Type => _type;
        public string WheelFormula => _wheelFormula;

        public double GetCurrentCapacity()
        {
            return _currentCapacity;
        }

        public void SetCurrentCapacity(double value)
        {
            if (value > 0)
            {
                SetCurrentCapacity(value);
            }
        }
        public double MaxCapacity => _maxCapacity;
        public double BodyVolume => _bodyVolume;
        public string DischargeDirection => _dischargeDirection;
        public double FifthWheelHeight => _fifthWheelHeight;
        public double BodyLength => _bodyLength;

        public void AddProduct(IProduct product)
        {
            if ((GetCurrentCapacity() + product.Quantity * product.WeightPerUnit) < MaxCapacity)
            {
                SetCurrentCapacity(GetCurrentCapacity() + product.Quantity * product.WeightPerUnit);
            }
            else throw new Exception("Impossible to add product");
        }
    }
}
