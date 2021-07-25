using Epam_Task2.Interfaces;
using Epam_Task2.Semitrailers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Epam_Task2.Factories
{
    internal class Wielton : ITruckingIndustry
    {
        public ISemitrailer GetSemitrailer()
        {
            return new Refrigerator();
        }
    }
}
