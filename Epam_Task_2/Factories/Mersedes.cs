using Epam_Task_2.Interfaces;
using Epam_Task_2.Semitrailers;

namespace Epam_Task_2.Factories
{
    internal class Mersedes : ITruckingIndustry
    {
        public ISemitrailer GetSemitrailer()
        {
            return new Cistern();
        }
    }
}
