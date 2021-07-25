using Epam_Task_2.Interfaces;
using Epam_Task_2.Semitrailers;

namespace Epam_Task_2.Factories
{
    /// <summary>
    /// This class describing Wielton factory
    /// </summary>
    internal class Wielton : ITruckingIndustry
    {
        /// <summary>
        /// Method for getting refrigerator semitrailer
        /// </summary>
        /// <returns>Object of type refrigerator</returns>
        public ISemitrailer GetSemitrailer()
        {
            return new Refrigerator();
        }
    }
}
