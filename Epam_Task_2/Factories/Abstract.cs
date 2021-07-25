using Epam_Task_2.Interfaces;
using Epam_Task_2.Semitrailers;
using System;

namespace Epam_Task_2.Factories
{
    internal class Abstract : ITruckingIndustry
    {
        private readonly string _type;
        private readonly string _wheelFormula;
        private readonly double _currentCapacity;
        private readonly double _maxCapacity;
        private readonly double _bodyVolume;
        private readonly string _dischargeDirection;
        private readonly double _fifthWheelHeight;
        private readonly double _bodyLength;

        public Abstract(string type,
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

        public override bool Equals(object obj)
        {
            return obj is Abstract @abstract &&
                   _type == @abstract._type &&
                   _wheelFormula == @abstract._wheelFormula &&
                   _currentCapacity == @abstract._currentCapacity &&
                   _maxCapacity == @abstract._maxCapacity &&
                   _bodyVolume == @abstract._bodyVolume &&
                   _dischargeDirection == @abstract._dischargeDirection &&
                   _fifthWheelHeight == @abstract._fifthWheelHeight &&
                   _bodyLength == @abstract._bodyLength;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_type, _wheelFormula, _currentCapacity, _maxCapacity, _bodyVolume, _dischargeDirection, _fifthWheelHeight, _bodyLength);
        }

        public ISemitrailer GetSemitrailer() => new AbstractSemitrailer(
            _type,
            _wheelFormula,
            _currentCapacity,
            _maxCapacity,
            _bodyVolume,
            _dischargeDirection,
            _fifthWheelHeight,
            _bodyLength);
    }
}
