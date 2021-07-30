using Epam_Task_2.Interfaces;
using System;

namespace Epam_Task_2.Semitrailers
{
    /// <summary>
    /// This class describing abstract semitrailer
    /// </summary>
    internal class AbstractSemitrailer : ISemitrailer
    {
        private readonly string _type;
        private readonly string _wheelFormula;
        private double _currentCapacity;
        private readonly double _maxCapacity;
        private readonly double _bodyVolume;
        private readonly string _dischargeDirection;
        private readonly double _fifthWheelHeight;
        private readonly double _bodyLength;

        /// <summary>
        /// Constructor initializes abstract semitrailer parameter
        /// </summary>
        /// <param name="type">semitrailer type</param>
        /// <param name="wheelFormula">semitrailer wheel formula</param>
        /// <param name="currentCapacity">semitrailer current capacity</param>
        /// <param name="maxCapacity">semitrailer max capacity</param>
        /// <param name="bodyVolume">semitrailer body volume</param>
        /// <param name="dischargeDirection">semitrailer discharge direction</param>
        /// <param name="fifthWheelHeight">semitrailer fifth wheel height</param>
        /// <param name="bodyLength">semitrailer body length</param>
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

        /// <summary>
        /// Method for getting current capacity of abstract semitrailer
        /// </summary>
        /// <returns>current capacity</returns>
        public double GetCurrentCapacity()
        {
            return _currentCapacity;
        }

        /// <summary>
        /// Method for setting current capacity of abstract semitrailer
        /// </summary>
        /// <param name="value">current capacity value</param>
        public void SetCurrentCapacity(double value)
        {
            if (value > 0)
            {
                _currentCapacity = value;
            }
        }
        public double MaxCapacity => _maxCapacity;
        public double BodyVolume => _bodyVolume;
        public string DischargeDirection => _dischargeDirection;
        public double FifthWheelHeight => _fifthWheelHeight;
        public double BodyLength => _bodyLength;

        /// <summary>
        /// Method for adding product in abstract semitrailer
        /// </summary>
        /// <param name="product">product</param>
        public void AddProduct(IProduct product)
        {
            if ((GetCurrentCapacity() + product.Quantity * product.WeightPerUnit) < MaxCapacity)
            {
                SetCurrentCapacity(GetCurrentCapacity() + product.Quantity * product.WeightPerUnit);
            }
            else throw new Exception("Impossible to add product");
        }

        public override bool Equals(object obj)
        {
            return obj is AbstractSemitrailer semitrailer &&
                   _type == semitrailer._type &&
                   _wheelFormula == semitrailer._wheelFormula &&
                   _currentCapacity == semitrailer._currentCapacity &&
                   _maxCapacity == semitrailer._maxCapacity &&
                   _bodyVolume == semitrailer._bodyVolume &&
                   _dischargeDirection == semitrailer._dischargeDirection &&
                   _fifthWheelHeight == semitrailer._fifthWheelHeight &&
                   _bodyLength == semitrailer._bodyLength &&
                   Type == semitrailer.Type &&
                   WheelFormula == semitrailer.WheelFormula &&
                   MaxCapacity == semitrailer.MaxCapacity &&
                   BodyVolume == semitrailer.BodyVolume &&
                   DischargeDirection == semitrailer.DischargeDirection &&
                   FifthWheelHeight == semitrailer.FifthWheelHeight &&
                   BodyLength == semitrailer.BodyLength;
        }

        public override int GetHashCode()
        {
            HashCode hash = new HashCode();
            hash.Add(_type);
            hash.Add(_wheelFormula);
            hash.Add(_currentCapacity);
            hash.Add(_maxCapacity);
            hash.Add(_bodyVolume);
            hash.Add(_dischargeDirection);
            hash.Add(_fifthWheelHeight);
            hash.Add(_bodyLength);
            hash.Add(Type);
            hash.Add(WheelFormula);
            hash.Add(MaxCapacity);
            hash.Add(BodyVolume);
            hash.Add(DischargeDirection);
            hash.Add(FifthWheelHeight);
            hash.Add(BodyLength);
            return hash.ToHashCode();
        }

        public override string ToString()
        {
            return string.Format($@"Type: {_type} 
                                    WheelFormula: {_wheelFormula} 
                                    CurrentCapacity: {_currentCapacity}
                                    MaxCapacity: {_maxCapacity}
                                    BodyVolume: {_bodyVolume}
                                    DischargeDirection: {_dischargeDirection}
                                    FiftWheelHeight: {_fifthWheelHeight}");
        }
    }
}
