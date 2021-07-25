using Epam_Task_2.Interfaces;
using Epam_Task_2.Semitrailers;

namespace Epam_Task_2.Factories
{
    /// <summary>
    /// This class describing Mersedes factory
    /// </summary>
    internal class Mersedes : ITruckingIndustry
    {
        /// <summary>
        /// Method for getting cistern semitrailer
        /// </summary>
        /// <returns>Object of type Cistern</returns>
        public ISemitrailer GetSemitrailer()
        {
            return new Cistern();
        }
    }
}
