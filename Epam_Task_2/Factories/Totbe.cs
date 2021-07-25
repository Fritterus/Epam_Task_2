using Epam_Task_2.Interfaces;
using Epam_Task_2.Semitrailers;

namespace Epam_Task_2.Factories
{
    /// <summary>
    /// This class describing Totbe factory
    /// </summary>
    internal class Totbe : ITruckingIndustry
    {
        /// <summary>
        /// Method for getting awning semitrailer
        /// </summary>
        /// <returns>Object of type awning</returns>
        public ISemitrailer GetSemitrailer()
        {
            return new Awning();
        }
    }
}
